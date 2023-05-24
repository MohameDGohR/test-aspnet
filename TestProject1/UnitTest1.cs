using test_aspnet.models;

namespace TestProject1
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            
        }
        [Fact]
        public void Test1()
        {
            var c = new Car();
            var speed = c.calculateSpeed();
            Assert.Equal(10, speed);
        }
    }
}