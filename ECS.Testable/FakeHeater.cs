namespace ECS.Testable
{
    public class FakeHeater : IHeater
    {
        public ILogger _logger {get; set;}

        public FakeHeater()
        {
            _logger = new FakeLogger();
        }
        public void TurnOn()
        {
            _logger.WriteLogLine("Heater Turned On");
        }
        public void TurnOff()
        {
            _logger.WriteLogLine("Heater Turned Off");
        }
        public bool RunSelfTest()
        {
            return true;
        }
    }
}