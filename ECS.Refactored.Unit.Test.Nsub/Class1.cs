using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;

namespace ECS.Refactored.Unit.Test.Nsub
{
    [TestFixture]
    public class EcsUnitTestNsubstitute
    {
        [Test]
        public void Regulate_TempUnderThreshold_heaterIsOn()
        {
            var mockHeater = Substitute.For<IHeater>();
            var stubSensor = Substitute.For<ITempSensor>();
            stubSensor.GetTemp().Returns(45);
            int threshold = 50;
            ECS ecs = new ECS(threshold,stubSensor, mockHeater);
            ecs.Regulate();
            mockHeater.Received(1).TurnOn();
        }

        [Test]
        public void Regulate_TempOverThreshold_heaterReceivedOff()
        {
            var mockHeater = Substitute.For<IHeater>();
            var stubSensor = Substitute.For<ITempSensor>();
            int threshold = 50;
            stubSensor.GetTemp().Returns(51);
            var uut = new ECS(threshold, stubSensor, mockHeater);
            uut.Regulate();
            mockHeater.Received(0).TurnOn();
            mockHeater.Received(1).TurnOff();
        }
    }
}
