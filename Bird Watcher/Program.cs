namespace Bird_Watcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BirdCount bird;
            Console.WriteLine(bird = new BirdCount(new int[] { 2, 5, 0, 7, 4, 1 }));
            bird.IncrementTodaysCount();
            Console.WriteLine();

        }
    }

    class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            return new int[] { 0, 2, 5, 3, 7, 8, 4 };
        }

        public int Today()
        {
            return birdsPerDay[birdsPerDay.Length - 1];
        }

        public void IncrementTodaysCount()
        {
            birdsPerDay[birdsPerDay.Length - 1] += 1;
        }

        public bool HasDayWithoutBirds()
        {
            foreach (var b in birdsPerDay)
            {
                if (b is 0) return true;
            }
            return false;

        }

        public int CountForFirstDays(int numberOfDays)
        {
            int birds = 0;
            for (int i = 0; i < numberOfDays; i++) birds += birdsPerDay[i];
            return birds;
        }

        public int BusyDays()
        {
            int busy = 0;
            foreach (var b in birdsPerDay) busy += b >= 5 ? 1 : 0;
            return busy;
        }
    }
}