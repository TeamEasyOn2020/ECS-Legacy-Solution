namespace ECS.Testable
{
    public interface IHeater
    {
        ILogger _logger {get; set;}
        public void TurnOn();
        public void TurnOff();
        public bool RunSelfTest();
    }
}
