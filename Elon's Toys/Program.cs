namespace Elon_s_Toys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControlCar car;
            Console.WriteLine(car = RemoteControlCar.Buy());

            Enumerable.Range(0, 72).ToList().ForEach(x => car.Drive());
            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());

            Enumerable.Range(0, 24).ToList().ForEach(x => car.Drive());
            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());

            Enumerable.Range(0, 14).ToList().ForEach(x => car.Drive());
            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());
        }
    }

    class RemoteControlCar
    {
        private int Battery = 100;
        private int Meter = 0;
        public static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }

        public string DistanceDisplay()
        {
            return $"Driven {Meter} meters";
        }

        public string BatteryDisplay()
        {
            return Battery is 0 ? $"Battery empty" : $"Battery at {Battery}%";
        }

        public void Drive()
        {
            if (Battery is 0) return;

            Battery -= 1;
            Meter += 20;
        }
    }
}