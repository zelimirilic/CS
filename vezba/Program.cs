using System;

namespace vezba {
    class Program {
        static void Main (string[] args) {
            // Your Age
            int userAge = 46;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter

            double newJupiterAge = newEarthAge / jupiterYears;
            int a = 1;
            int b = 2;
            int c = 3;
            int d = a + b * c;

            // Log calculations to console
            Console.WriteLine (jupiterAge);
            Console.WriteLine (journeyToJupiter);
            Console.WriteLine (newEarthAge);
            Console.WriteLine (newJupiterAge);
            Console.WriteLine (d);

            // User Name
            string name = "Farhad Hesam Abbasi";

            // Get first letter
            int firstName = name.IndexOf ("Farhad");
            char firstLetter = name[firstName];

            // Get last name
            int charPosiostion = name.IndexOf ("Abbasi");
            string lastName = name.Substring (charPosiostion);

            // Print results
            Console.WriteLine (firstLetter);
            Console.WriteLine(lastName);
        }
    }
}