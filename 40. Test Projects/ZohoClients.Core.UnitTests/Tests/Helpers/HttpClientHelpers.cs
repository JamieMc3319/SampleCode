using System.Runtime.Serialization;

namespace ZohoClients.Core.UnitTests.Tests.Helpers
{
    public class HttpClientHelpers
    {

        [Fact]
        public void AddParamsToQueryString()
        {
            // Assign
            var model = new { 
                prop1 = "value1",
                prop2 = 2,
                prop3 = true
            };

            var expected = "prop1=value1&prop2=2&prop3=true";

            // Act
            var actual = new Impl.Helpers.HttpClientHelpers(_httpClient).AddParamsToQueryString(model);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddParamsToQueryString2()
        {
            // Assign
            var model = new TestClass
            {
                Prop1 = "value1",
                Prop2 = TestClass.Prop2Enum.Prop2Value2,
                Prop3 = null
            };

            var expected = "Prop1=value1&Prop2Name=Prop2Value2Text";

            // Act
            var actual = new Impl.Helpers.HttpClientHelpers(_httpClient).AddParamsToQueryString(model);

            // Assert
            Assert.Equal(expected, actual);
        }


        // Test Resources

        private static readonly HttpClient _httpClient = new();

        public class TestClass
        {
            public string? Prop1 { get; set; }

            [Attributes.QueryStringParameterName("Prop2Name")]
            public Prop2Enum Prop2 { get; set; }

            public string? Prop3 { get; set; }

            public enum Prop2Enum
            {
                Prop2Value1,

                [EnumMember(Value = "Prop2Value2Text")]
                Prop2Value2
            }
        }
    }
}