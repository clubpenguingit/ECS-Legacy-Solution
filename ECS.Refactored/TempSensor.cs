using System;
namespace ECS.Refactored
{
    public class TempSensor : ITempSensor
    {
        private Random _gen = new Random();

        public int GetTemp()
        {
            return _gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}