using ECS.Testable;
using NUnit.Framework;


namespace ECS.UnitTest
{
    public class Tests
    {
        private Testable.ECS uut;
        [SetUp]
        public void Setup()
        {
            var faketemp = new FakeTempSensor();
            var fakeheat = new FakeHeater();
            uut = new Testable.ECS(20, faketemp, fakeheat);
        }

        [TestCase(2)]
        [TestCase(-5)]
        [TestCase(20)]
        [Test]
        public void SetThreshold_NewThreshold_EqualsNewThreshold(int threshold)
        {
            //Arange setup

            // Act
            uut.SetThreshold(threshold);
            // Assert
            Assert.That(uut.GetThreshold(),Is.EqualTo(threshold) );
        }
    }
}