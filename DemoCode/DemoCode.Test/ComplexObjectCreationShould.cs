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
    public class ComplexObjectCreationShould
    {
        [Fact]
        public void CreateObject()
        {
            var fixture = new Fixture();
            var emailMessage = fixture.Create<EmailMessage>();

            emailMessage.Should().NotBeNull();
        }

        [Fact]
        public void CreateComplexObject()
        {
            var fixture = new Fixture();
            Order order = fixture.Create<Order>();

            order.Should().NotBeNull();

        }
        [Fact]
        public void CreateCustomObjects()
        {
            var fixture = new Fixture();
            fixture.Inject<string>("PDO");
            Product product = fixture.Create<Product>();

        }
    }
}
