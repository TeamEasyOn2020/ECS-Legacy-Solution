using ECS.Testable;
using NUnit.Framework;


namespace ECS.UnitTest
{
    public class Tests
    {
        private FakeTempSensor faketemp;
        private FakeHeater fakeheat;
        private Testable.ECS uut;
        [SetUp]
        public void Setup()
        {
            fakeheat = new FakeHeater();
            faketemp = new FakeTempSensor();
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

        [TestCase(2, "On")]
        [TestCase(25, "Off")]
        [TestCase(20,"Off")]
        [Test]
        public void Regualte_Temp_EqualsResult(int temp, string result)
        {
            //Arange setup
            faketemp.FakeTemp = temp;
            // Act
            uut.Regulate();
            // Assert
            Assert.That(fakeheat.HeaterState, Is.EqualTo(result));
        }

        [TestCase(2)]
        [TestCase(25)]
        [TestCase(20)]
        [Test]
        public void GetCurTemp_Temp_EqualsTemp(int temp)
        {
            //Arange setup
            faketemp.FakeTemp = temp;
            // Act
            
            // Assert
            Assert.That(uut.GetCurTemp(), Is.EqualTo(temp));
        }

        [Test]
        public void RunselfTest_EqualsTrue()
        {
            //Arange setup

            // Act
            
            // Assert
            Assert.That(uut.RunSelfTest(), Is.EqualTo(true));
        }
    }
}