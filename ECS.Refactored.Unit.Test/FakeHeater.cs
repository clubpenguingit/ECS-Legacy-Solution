namespace ECS.Refactored.Unit.Test
{
    public class FakeHeater : IHeater
    {
        public bool HeaterState { get; set; }

        public void TurnOff()
        {
            HeaterState = false;
        }

        public void TurnOn()
        {
            HeaterState = true;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}