namespace ECS.Testable
{
    public class Heater : IHeater
    {
        public ILogger _logger {get; set;}
        public Heater(ILogger logger)
        {
            _logger = logger;
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
