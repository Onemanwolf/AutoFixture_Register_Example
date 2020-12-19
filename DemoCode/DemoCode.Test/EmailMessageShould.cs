using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using FluentAssertions;
using AutoFixture;
using Xunit;

namespace DemoCode.Test
{
    public class EmailMessageShould
    {
        [Fact]
        public void EmailMessageCreate()
        {
            var fixture = new Fixture();


            MailAddress toAddress = fixture.Create<MailAddress>();
            MailAddress fromAddress = fixture.Create<MailAddress>();
            var s = fixture.Create<string>("Subject");
            var Id = fixture.Create<Guid>();
            var sut = new EmailMessage(
                Id,
                toAddress.Address,
                fromAddress.Address,
                fixture.Create<string>("Subject"),
                fixture.Create<string>("Body"),
                fixture.Create<bool>());

            sut.Id.Should().Be(Id);
            sut.ToAddress.Should().Be(toAddress.Address);
            sut.FromAddress.Should().Be(fromAddress.Address);
            sut.Subject.Should().Contain("Subject");
            sut.Body.Should().Contain("Body");


        }
    }
}
