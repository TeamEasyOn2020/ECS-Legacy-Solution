namespace ECS.Testable
{
    public class FakeHeater : IHeater
    {
        public string HeaterState { get; set; }
        public void TurnOn()
        {
            HeaterState = "On";
        }
        public void TurnOff()
        {
            HeaterState = "Off";
        }
        public bool RunSelfTest()
        {
            return true;
        }
    }
}