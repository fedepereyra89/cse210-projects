using System;

namespace Foundation4
{
    class Program
    {
        static void Main()
        {
            Running running = new Running("03 Nov 2022", 30, 3);
            Cycling cycling = new Cycling("20 Oct 2020", 60, 12);
            Swimming swimming = new Swimming("13 July 2012", 45, 20);
            List<Activity> activities = new List<Activity>();
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            foreach (Activity activity in activities)
            {
                activity.GetSummary();
            }
        }
    }
}