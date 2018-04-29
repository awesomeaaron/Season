using System;

namespace DateApp
{
    class Program
    {
        static void Main(string[] args)
        {        
            IDateProvider dateProvider = new DateProvider();
            SeasonFinder seasonFinder = new SeasonFinder();
            var season = seasonFinder.Find(dateProvider);

            Console.WriteLine(season);
            Console.Read();
        }
    }
}
