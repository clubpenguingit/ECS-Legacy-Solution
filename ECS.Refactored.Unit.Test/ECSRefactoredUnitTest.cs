using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Refactored.Unit.Test
{
    [TestFixture]
    public class ECSRefactoredUnitTest
    {
        
        private ECS uut;
        private FakeHeater mockHeater;
        private FakeTempSensor stubTempSensor;
        [SetUp]
        public void SetUp()
        {
            mockHeater = new FakeHeater();
            stubTempSensor = new FakeTempSensor();
            uut = new ECS(75, stubTempSensor, mockHeater);
        }

        [Test]
        public void JenkinsTest()
        {
            Assert.That(true, Is.True);
        }

        [Test]
        public void Regulate_TempExceedsThreshold_TurnOffHeater()
        {

            uut.SetThreshold(50);
            stubTempSensor.Temp = 55; // Above threshold
            uut.Regulate();       // Regulate will turn off heater. 
            Assert.That(mockHeater.HeaterState, Is.EqualTo(false));
        }
    }



}
