namespace Need_for_Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class RemoteControlCar
    {
        int battery = 100;
        int distanceDrived = 0;

        int speed = 0;
        int batteryDrain = 0;
        // TODO: define the constructor for the 'RemoteControlCar' class
        public RemoteControlCar(int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;
        }
        public bool BatteryDrained()
        {
            return (battery - batteryDrain) < 0;
        }

        public int DistanceDriven()
        {
            return distanceDrived;
        }

        public void Drive()
        {
            if (BatteryDrained()) return;

            battery -= batteryDrain;
            distanceDrived += speed;
        }

        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50, 4);
        }
    }

    class RaceTrack
    {
        int distance = 0;

        // TODO: define the constructor for the 'RaceTrack' class
        public RaceTrack(int distance)
        {
            this.distance = distance;
        }
        public bool TryFinishTrack(RemoteControlCar car)
        {
            while (!car.BatteryDrained()) car.Drive();

            return car.DistanceDriven() >= distance;
        }
    }
}