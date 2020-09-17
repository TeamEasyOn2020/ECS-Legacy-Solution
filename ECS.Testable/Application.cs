namespace ECS.Testable
{
    public class Application
    {
        public static void Main(string[] args)
        {
            var temp = new FakeTempSensor();
            var heater = new FakeHeater();
            var ecs = new ECS(28,temp,heater);

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();
        }
    }
}
