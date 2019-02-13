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
        [SetUp]
        public void SetUp()
        {
            uut = new ECS(75, new FakeTempSensor(), new FakeHeater());
        }

        [Test]
        public void JenkinsTest()
        {
            Assert.That(true, Is.True);
        }
    }



}
