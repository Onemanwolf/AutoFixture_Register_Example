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
    public class SequenceDemoShould
    {
        [Fact]
        public void SequenceOfStrings()
        {
            var fixture = new Fixture();
            IEnumerable<Order> list = fixture.CreateMany<Order>(1060);

            var listCount = list;

            listCount.Should().HaveCount(1060);

        }


        [Fact]
        public void SequenceOfStringsAddToList()
        {
            var fixture = new Fixture();
            var list = new List<string>();


            fixture.AddManyTo(list, 10);

            list.Should().HaveCount(10);

        }
    }
}
