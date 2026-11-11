using Xunit;
using MyApp;

namespace MyApp.xUnitTests
{
    public class PasswordCheckerTests
    {
        [Fact]
        public void IsStrong_ValidPassword_ReturnsTrue()
        {
            // Arrange
            var checker = new PasswordStrengthChecker();

            // Act
            var result = checker.IsStrong("StrongPass123");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsStrong_TooShort_ReturnsFalse()
        {
            var checker = new PasswordStrengthChecker();
            var result = checker.IsStrong("Sh0rt");
            Assert.False(result);
        }

        [Fact]
        public void IsStrong_NoDigits_ReturnsFalse()
        {
            var checker = new PasswordStrengthChecker();
            var result = checker.IsStrong("NoDigitsHere");
            Assert.False(result);
        }

        [Fact]
        public void IsStrong_NoUpperCase_ReturnsFalse()
        {
            var checker = new PasswordStrengthChecker();
            var result = checker.IsStrong("nouppercase123");
            Assert.False(result);
        }

        [Fact]
        public void IsStrong_NoLowerCase_ReturnsFalse()
        {
            var checker = new PasswordStrengthChecker();
            var result = checker.IsStrong("NOLOWERCASE123");
            Assert.False(result);
        }

        [Fact]
        public void IsStrong_NullOrEmpty_ReturnsFalse()
        { 
            var  checker = new PasswordStrengthChecker();
            Assert.False(checker.IsStrong(""));
            Assert.False(checker.IsStrong(null));
        }
    }
}