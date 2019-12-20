using System;
using Xunit;

namespace Numeronym.Core.Tests
{
    public class NumeronymGeneratorTest
    {
        [Theory]
        [InlineData("kubernetes", "k8s")]
        [InlineData("internationalization", "i18n")]
        public void GenerateTheory(String toConvert, string expected)
        {
            String actual = NumeronymGenerator.Generate(toConvert);
            Assert.Equal(expected, actual);
        }
    }
}
