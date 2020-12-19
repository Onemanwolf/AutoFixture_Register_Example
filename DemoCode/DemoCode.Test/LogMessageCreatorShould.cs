using AutoFixture;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoCode.Test
{
    public class LogMessageCreatorShould
    {
        [Fact]
        public void CreateLogMessage()
        {
            var sut = new LogMessageCreator();
            var fixture = new Fixture();
            var id = fixture.Create<Guid>();
            var messageType = fixture.Create<MessageType>();
            DateTime logTime = fixture.Create<DateTime>();

            LogMessage result = sut.Create(fixture.Create<string>(), logTime, id, messageType);

            result.Id.Should().Be(id);
            logTime.Year.Should().Be(result.Year);
            Assert.Equal(logTime.Year, result.Year);


        }
    }
}
