using Json.More;
using Json.Schema;

using NUnit.Framework;

using System;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace OpenWinSpec.Validation.Tests
{
    public static class ResultsExtension
    {
        public static void AsserValid(this ValidationResults results, string expected = null)
        {
            Console.WriteLine(JsonSerializer.Serialize(results, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }));

            Assert.True(results.IsValid);
            AssertEquivalent(results, expected);
        }

        private static void AssertEquivalent(ValidationResults results, string expected = null)
        {
            if (expected == null) return;

            var expectedJson = JsonDocument.Parse(expected).RootElement;
            var actualJson = JsonDocument.Parse(JsonSerializer.Serialize(results)).RootElement;

            Assert.IsTrue(expectedJson.IsEquivalentTo(actualJson));
        }

        public static void AssertInvalid(this ValidationResults results, string expected = null)
        {
            Console.WriteLine(JsonSerializer.Serialize(results, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }));

            Assert.False(results.IsValid);
            AssertEquivalent(results, expected);
        }
    }
}
