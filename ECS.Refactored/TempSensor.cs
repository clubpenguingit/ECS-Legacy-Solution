using System;
namespace ECS.Refactored
{
    public class TempSensor : ITempSensor
    {
        private IRandomNumGenerator _gen = new RandomNumGenerator();

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