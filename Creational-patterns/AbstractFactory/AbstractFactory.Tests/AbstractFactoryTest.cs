using Xunit;

namespace AbstractFactory.Tests
{
    public class AbstractFactoryTest
    {
       private AbstractFactoryDemo _factory;
        [Fact]
        public void SampleTest()
        {
            Assert.Equal(0,0);
        }

        [Fact]
        public void EmberToolkitTest() 
        {
            var factory = AbstractFactoryDemo.GetAbstractFactory(Architecture.Ember);
            Assert.IsType<EmberToolkit>(factory);
        }

        [Fact]
        public void EnginolaToolkitTest()
        {
            var factory = AbstractFactoryDemo.GetAbstractFactory(Architecture.Enginola);
            Assert.IsType<EnginolaToolkit>(factory);
        }
    }
}
