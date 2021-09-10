using System;
using Xunit;
using System.IO;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        /*[Fact]
        public void Main_prints_Hello_World()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main(new string[0]);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!",output);
        }*/

        [Theory]
        [InlineData("1912")]
        [InlineData("1992")]
        [InlineData("2400")]
        [InlineData("2000")]
        [InlineData("2304")]
        [InlineData("1640")]
        public void ValidateLeapYear_Prints_Yay(string year)
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.ValidateLeapYear(year);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay",output);
        }
        
        [Theory]
        [InlineData("2005")]
        [InlineData("8009")]
        [InlineData("1599")]
        [InlineData("2001")]
        [InlineData("1910")]
        [InlineData("2010")]
        public void ValidateLeapYear_Prints_Nay(string year)
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.ValidateLeapYear(year);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay",output);
        }
        
        [Theory]
        [InlineData("Onehundredandone")]
        [InlineData("Year one")]
        [InlineData("Year 2004")]
        [InlineData("2004y")]
        [InlineData("Seven")]
        [InlineData("0")]
        [InlineData("40")]
        [InlineData("100")]
        [InlineData("1582")]
        public void ValidateLeapYear_Prints_enter_valid_year(string year)
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.ValidateLeapYear(year);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Please enter a numeric year after 1582. For instance '2021'",output);
        }
    }
}
