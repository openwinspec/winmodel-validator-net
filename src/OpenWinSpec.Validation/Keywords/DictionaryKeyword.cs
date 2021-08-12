using Json.More;
using Json.Pointer;
using Json.Schema;

using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenWinSpec.Validation.Keywords
{

    /// <summary>
    /// Handles `dictionary`
    /// </summary>
    [SchemaKeyword(Name)]
    [JsonConverter(typeof(DictionaryKeywordConverter))]
    [SchemaDraft(Draft.Draft201909)]
    [SchemaDraft(Draft.Draft202012)]
    [Vocabulary(OpenWinSpecv1.OpenWinSpecVocabularyId)]
    public class DictionaryKeyword : IJsonSchemaKeyword, IEquatable<DictionaryKeyword>
    {
        internal const string Name = "dictionary";

        public DictionaryKeyword(JsonPointer path, string key)
        {
            Path = path;
            Key = key ?? throw new ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Reference to dictionary
        /// </summary>
        public JsonPointer Path { get;}

        /// <summary>
        /// Field of dictionary
        /// </summary>
        public string Key { get; }


        /// <summary>
        /// Provides validation for the keyword
        /// </summary>
        /// <param name="context">Contextual details for the validation process</param>
        public void Validate(ValidationContext context)
        {
            context.EnterKeyword(Name);

            var dictionary = Path.Evaluate(context.InstanceRoot);
            if(dictionary.HasValue)
            {
                if(dictionary.Value.ValueKind == JsonValueKind.Array)
                {
                    foreach (var item in dictionary.Value.EnumerateArray())
                    {
                        if(item.ValueKind != JsonValueKind.Object)
                        {
                            context.IsValid = false;
                            context.Message = $"Dictionary item is {item.ValueKind} but should be {JsonValueKind.Object}";
                            break;
                        }

                        if (!item.TryGetProperty(Key, out var value))
                        {
                            context.Message = $"Property '{Key}' does not exist.";
                            context.IsValid = false;
                            break;
                        }

                        if (value.ValueKind != context.LocalInstance.ValueKind)
                        {
                            context.Message = $"Value is {value.ValueKind} but should be {context.LocalInstance.ValueKind}";
                            context.IsValid = false;
                            break;
                        }

                        if (JsonElementEqualityComparer.Instance.Equals(value, context.LocalInstance))
                        {
                            context.IsValid = true;
                            break;
                        }
                    }
                }
                else
                {
                    context.IsValid = false;
                    context.Message = $"Dictionary is {dictionary.Value.ValueKind} but should be {JsonValueKind.Array}";
                }
            }
            else
            {
                context.Message = $"Coult not find the dictionary \"{ Path}\"";
                context.IsValid = false;
            }

            context.ExitKeyword(Name);
        }

        #region Equals

        // override object.Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as DictionaryKeyword);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return RuntimeHelpers.GetHashCode(this);
        }

        public bool Equals(DictionaryKeyword other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Path.Equals(other.Path) && Key.Equals(other.Key);
        }

        #endregion

    }

    internal class DictionaryKeywordConverter : JsonConverter<DictionaryKeyword>
    {
        public override DictionaryKeyword Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException("Expected object");
            var impl = JsonSerializer.Deserialize<DictionaryImpl>(ref reader, options);
            return new DictionaryKeyword(JsonPointer.Parse(impl.Path), impl.Key);
        }

        public override void Write(Utf8JsonWriter writer, DictionaryKeyword value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(DictionaryKeyword.Name);
            writer.WriteStartObject();
            writer.WriteString("path", value.Path.ToString());
            writer.WriteString("key", value.Key);
            writer.WriteEndObject();
        }

        internal class DictionaryImpl
        {
            public string Path { get;}

            public string Key { get; }
        }
    }
}
