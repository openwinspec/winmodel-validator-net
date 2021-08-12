using Json.Pointer;
using Json.Schema;

using OpenWinSpec.Validation.Keywords;

namespace OpenWinSpec.Validation
{
    public static class JsonSchemaBuilderExtensions
    {
        public static JsonSchemaBuilder Builder()
        {
            return new JsonSchemaBuilder();
        }

        public static JsonSchemaBuilder Dictionary(this JsonSchemaBuilder builder, string path, string key)
        {
            builder.Add(new DictionaryKeyword(JsonPointer.Parse(path), key));
            return builder;
        }
    }
}
