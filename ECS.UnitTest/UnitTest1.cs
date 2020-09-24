using ECS.Testable;
using NUnit.Framework;
using NSubstitute;

namespace ECS.UnitTest
{
    public class Tests
    {
        private ITempSensor fakeTempSensor;
        private IHeater fakeHeater;

        private Testable.ECS uut;
        [SetUp]
        public void Setup()
        {
            fakeTempSensor = Substitute.For<ITempSensor>();
            fakeHeater = Substitute.For<IHeater>();
            uut = new Testable.ECS(20, fakeTempSensor, fakeHeater);
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

        [TestCase(2)]
        [TestCase(15)]
        [TestCase(19)]
        [Test]
        public void Regualte_TempLow_TurnOnHeater(int temp)
        {
            //Arange setup
            fakeTempSensor.GetTemp().Returns(temp);
            // Act
            uut.Regulate();
            // Assert
            fakeHeater.Received(1).TurnOn();
        }

        [TestCase(20)]
        [TestCase(25)]
        [TestCase(39)]
        [Test]
        public void Regualte_TempHigh_TurnOffHeater(int temp)
        {
            //Arange setup
            fakeTempSensor.GetTemp().Returns(temp);
            // Act
            uut.Regulate();
            // Assert
            fakeHeater.Received(1).TurnOff();
        }

        [TestCase(2)]
        [TestCase(25)]
        [TestCase(20)]
        [Test]
        public void GetCurTemp_Temp_EqualsTemp(int temp)
        {
            //Arange setup

            // Act

            // Assert
            fakeTempSensor.GetTemp().Returns(temp);
        }


        [TestCase(true, true, true)]
        [TestCase(true, false, false)]
        [TestCase(false, false, false)]
        [TestCase(false, true, false)]
        [Test]
        public void RunselfTest_EqualsTrue(bool fakeHeaterResult, bool fakeTempResult, bool result)
        {
            //Arange setup
            fakeHeater.RunSelfTest().Returns(fakeHeaterResult);
            fakeTempSensor.RunSelfTest().Returns(fakeTempResult);
            // Act

            // Assert
            Assert.That(uut.RunSelfTest(), Is.EqualTo(result));
        }
    }
}