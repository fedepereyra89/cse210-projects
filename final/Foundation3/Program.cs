using System;

namespace Foundation3
{
    class Program
    {
        static void Main()
        {
            Address address = new Address("Sanchez de Loria 2105", "Parque Patricios", "Buenos Aires", "Argentina");
            Lecture lecture = new Lecture("Devotional", "Come hear the Prophet Speak!", "10-10-2023", "11:15 AM", address, "President Russel M. Nelson", 300);
            Reception reception = new Reception("Wedding", "Congratulations!", "September", "20:00 PM", address, "Weddingday@centralpark.com");
            Outdoor outdoor = new Outdoor("Ward Picnic", "Come say hello to the ward!", "July 25", "12:00 PM", address, "Sunny weather. Bring a hat and sunscreen.");

            lecture.GetStandardDetails();
            lecture.GetFullDetails();
            lecture.GetShortDescription();

            reception.GetStandardDetails();
            reception.GetFullDetails();
            reception.GetShortDescription();

            outdoor.GetStandardDetails();
            outdoor.GetFullDetails();
            outdoor.GetShortDescription();

        }
    }
}