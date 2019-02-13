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
            uut = new ECS(50, stubTempSensor, mockHeater);
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

        [Test]
        public void Regulate_TempIsBelowThreshold_TurnOnHeater()
        {
            uut.SetThreshold(50);
            stubTempSensor.Temp = 45; // Under threshold
            uut.Regulate();       // Regulate will turn on heater. 
            Assert.That(mockHeater.HeaterState, Is.EqualTo(true));
        }

        [Test]
        public void Regulate_TempIsEqualToThreshold_TurnOffHeater()
        {
            uut.SetThreshold(50);
            stubTempSensor.Temp = 50; // Under threshold
            uut.Regulate();       // Regulate will turn on heater. 
            Assert.That(mockHeater.HeaterState, Is.EqualTo(false));
        }

        [Test]
        public void SetThreshold_PlusDegree_HoldsGivenValue()
        {
            int thr = 50;
            uut.SetThreshold(thr);
            Assert.That(uut.GetThreshold(), Is.EqualTo(thr));
        }

        [Test]
        public void SetThreshold_MinusDegree_HoldsGivenValue()
        {
            int thr = -150;
            uut.SetThreshold(thr);
            Assert.That(uut.GetThreshold(), Is.EqualTo(thr));
        }

        [Test]
        public void SetThreshold_InsertZero_HoldsGivenValue()
        {
            int thr = 0;
            uut.SetThreshold(thr);
            Assert.That(uut.GetThreshold(), Is.EqualTo(thr));
        }

        /// <summary>
        /// Lol
        /// </summary>
        [Test]
        public void SetThreshold_BigVal_HoldsGivenValue()
        {
            int thr = 999999999;
            uut.SetThreshold(thr);
            Assert.That(uut.GetThreshold(), Is.EqualTo(thr));
        }

        [Test]
        public void GetCurTemp_GetsTempFromStub_IsCorrect()
        {
            int temp = 50;
            stubTempSensor.Temp = temp;
            Assert.That(uut.GetCurTemp(), Is.EqualTo(temp));
        }
    }



}
