using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Refactored
{
    class Heater : IHeater
    {
        private IWriter _writer;

        public Heater()
        {
            _writer = new Writer();
        }
        public void TurnOn()
        {
            _writer.WriteLine("Heater is on");
        }

        public void TurnOff()
        {
            _writer.WriteLine("Heater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
