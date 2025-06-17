using FluentAssertions;

namespace WinTerpreters.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            5.Should().Be(4);
        }
    }
}