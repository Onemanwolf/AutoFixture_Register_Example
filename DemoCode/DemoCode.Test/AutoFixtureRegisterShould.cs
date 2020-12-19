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
    public class AutoFixtureRegisterShould
    {
        [Fact]
        public void RegisterInterface()
        {
            var fixture = new Fixture();
            fixture.Register<IMyInterface>(() => new Myclass());

            // Not used in test but demostrats generics support 
            fixture.Register<ITypeJoiner<string>>(() => new TypeJoiner<string>());
            var myClassImplementsMyInterface = fixture.Create<MyClassImplementsMyInterface>();
            var value = 1;
            var results = myClassImplementsMyInterface.DoSomething(value);

            results.Should().Be("Did something with value: 1");
        }
    }
}
