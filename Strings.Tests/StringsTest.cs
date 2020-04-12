using Xunit;

namespace Strings.Tests
{
    public class StringsTest
    {
        [Fact]
        public void ShouldReturnNull()
        {
            Assert.Null(Strings.ConvertToLowerCaseAndUnderscore(null));
        }

        [Fact]
        public void ShouldConvertToLowerCaseAndUnderscore()
        {
            Assert.Equal("hello_world", Strings.ConvertToLowerCaseAndUnderscore("Hello World"));
        }
    }
}
