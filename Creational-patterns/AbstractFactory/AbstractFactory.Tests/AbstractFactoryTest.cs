using System;
using Xunit;    
using ABC;

namespace AbstractFactory.Tests
{
    public class AbstractFactoryTest
    {
       // private AbstractFactoryDemo _factory;
        [Fact]
        public void SampleTest()
        {
            Program p = new Program();
            p.sayHello();
            Assert.Equal(0,0);
        }

        [Fact]
        public void EmberToolkitTest() 
        {
            // var factory = AbstractFactoryDemo.GetAbstractFactory(Architecture.Ember);
            // Assert.IsType<EmberToolkit>(factory);
        }
    }
}
