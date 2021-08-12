using Json.Schema;

using OpenWinSpec.Validation.Keywords;

using System;
using System.Linq;
using System.Reflection;

using static OpenWinSpec.Validation.JsonSchemaBuilderExtensions;

namespace OpenWinSpec.Validation
{
    public static class OpenWinSpecv1
    {
        public static readonly Uri OpenWinSpecSchemaId = new("https://openwinspec.org/orderschema.json");
        public const string OpenWinSpecVocabularyId = "https://openwinspec.org/orderschema.json";

        public static readonly JsonSchema OpenWinSpec = Builder()
            .Id(OpenWinSpecSchemaId)
            .Schema(MetaSchemas.Draft202012Id)
            .Vocabulary(
                (Vocabularies.Core202012Id, true),
                (Vocabularies.Applicator202012Id, true),
                (Vocabularies.Validation202012Id, true),
                (Vocabularies.Metadata202012Id, true),
                (Vocabularies.FormatAnnotation202012Id, true),
                (OpenWinSpecVocabularyId, true)
            )
            .DynamicAnchor("meta")
            .Title("Dictionary reference by key")
            .AllOf(Builder().Ref("https://json-schema.org/draft/2020-12/schema"))
            .Properties(
                (DictionaryKeyword.Name, Builder()
                    .Type(SchemaValueType.Object)
                    .Properties(
                        ("path", Builder().Type(SchemaValueType.String).Format(Formats.JsonPointer)),
                        ("key", Builder().Type(SchemaValueType.String))
                    ))
            );

        public static void Configure(VocabularyRegistry vocabularyRegistry = null, SchemaRegistry schemaRegistry = null)
        {
            var types = Assembly.GetCallingAssembly()
                .DefinedTypes
                .Where(x => typeof(IJsonSchemaKeyword).IsAssignableFrom(x) && !x.IsAbstract && !x.IsInterface)
                .Select(x => (Type: x, Vocabularies: x.GetCustomAttributes<VocabularyAttribute>()))
                .ToList();


            var vocabulary = new Vocabulary(
                OpenWinSpecVocabularyId,
                types.Where(x => x.Vocabularies.Any(v => v.Id.OriginalString == OpenWinSpecVocabularyId))
                .Select(x => x.Type));

            vocabularyRegistry ??= VocabularyRegistry.Global;
            vocabularyRegistry.Register(vocabulary);

            schemaRegistry ??= SchemaRegistry.Global;

            schemaRegistry.Register(OpenWinSpecv1.OpenWinSpecSchemaId, OpenWinSpecv1.OpenWinSpec);
        }
    }
}
