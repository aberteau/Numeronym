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

        [Fact]
        public void Generate_Null_When_Null()
        {
            String actual = NumeronymGenerator.Generate(null);
            Assert.Null(actual);
        }

        [Fact]
        public void Generate_Null_When_Whitespace()
        {
            String actual = NumeronymGenerator.Generate("  ");
            Assert.Null(actual);
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("aa", "aa")]
        [InlineData("aaa", "aaa")]
        public void Generate_Same_When_Length_Less_Than_3(String toConvert, string expected)
        {
            String actual = NumeronymGenerator.Generate(toConvert);
            Assert.Equal(expected, actual);
        }
    }
}
