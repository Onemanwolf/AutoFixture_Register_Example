using Xunit;
using FluentAssertions;
using AutoFixture;

namespace DemoCode.Test
{
    public class TypeJoinerShould
    {
       
        [Fact]
        public void TypeJoinerJoinTypeString()
        {
            var sut = new TypeJoiner<string>();
            var fixture = new Fixture();
            var valueOne = fixture.Create<string>();
            var valueTwo = fixture.Create<string>();
            var expected = valueOne + " " + valueTwo;

            sut.Join(valueOne, valueTwo);

            sut.Joined.Should().Be(expected);

        }
    }
}
