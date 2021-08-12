
using Json.Schema;

using NUnit.Framework;

using System.Text.Json;

using static OpenWinSpec.Validation.JsonSchemaBuilderExtensions;

namespace OpenWinSpec.Validation.Tests
{
    public class DictionaryKeywordTest
    {

        private readonly JsonSchema _dictionarySchema = new JsonSchemaBuilder()
            .Schema(OpenWinSpecv1.OpenWinSpecSchemaId)
            .Definitions(
                ("vendor", Builder()
                    .Type(SchemaValueType.Object)
                    .Properties(
                        ("id", Builder().Type(SchemaValueType.String)),
                        ("name", Builder().Type(SchemaValueType.String))
                    )),
                ("profile", Builder()
                    .Type(SchemaValueType.Object)
                    .Properties(
                        ("id", Builder().Type(SchemaValueType.String)),
                        ("name", Builder().Type(SchemaValueType.String)),
                        ("vendorId", Builder().Type(SchemaValueType.String)
                            .Dictionary("/vendors", "id"))
                    ))
            )
            .Properties(
                ("vendors", Builder().Type(SchemaValueType.Array).Items(Builder().Ref("#/definitions/vendor"))),
                ("profiles", Builder().Type(SchemaValueType.Array).Items(Builder().Ref("#/definitions/profile")))
            );

        [OneTimeSetUp]
        public void Setup()
        {
            ValidationOptions.Default.OutputFormat = OutputFormat.Detailed;
            OpenWinSpecv1.Configure();
        }

        [Test]
        public void Dictionary_Success()
        {
            var instance = JsonDocument.Parse(@"
            {
                ""vendors"": [
                {""id"": ""vendor01"", ""name"": ""First vendor""},
                {""id"": ""vendor02"", ""name"": ""Second vendor""}
                ],
                ""profiles"": [
                {""id"": ""profile01"", ""name"": ""First profile"", ""vendorId"": ""vendor01""},
                {""id"": ""profile01"", ""name"": ""Second profile"", ""vendorId"": ""vendor02""}
                ]
            }
            ").RootElement;

            var results = _dictionarySchema.Validate(instance);

            results.AsserValid();
        }

        [Test]
        public void Dictionary_Fail()
        {
            var instance = JsonDocument.Parse(@"
            {
                ""vendors"": [
                {""id"": ""vendor01"", ""name"": ""First vendor""},
                {""id"": ""invalid"", ""name"": ""Second vendor""}
                ],
                ""profiles"": [
                {""id"": ""profile01"", ""name"": ""First profile"", ""vendorId"": ""vendor01""},
                {""id"": ""profile01"", ""name"": ""Second profile"", ""vendorId"": ""vendor02""}
                ]
            }
            ").RootElement;

            var results = _dictionarySchema.Validate(instance);

            results.AssertInvalid();
        }
    }
}
