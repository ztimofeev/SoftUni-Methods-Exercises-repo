namespace CalculatingHumanAge
{
    using System;

    public class CalculatingHumanAge
    {
        public static void Main()
        {
            var yearOfBirth = int.Parse(Console.ReadLine());
            var monthOfBirth = int.Parse(Console.ReadLine());
            var dayOfBirth = int.Parse(Console.ReadLine());

            var age = GetAge(yearOfBirth, monthOfBirth, dayOfBirth);

            Console.WriteLine(age);
        }

        public static int GetAge(int year, int month, int day)
        {
            var now = DateTime.Now;

            var currentYear = now.Year;
            var currentMonth = now.Month;
            var currentDay = now.Day;

            var age = currentYear - year;

            if (currentMonth <= month || (currentMonth == month && day < currentDay))
            {
                age--;
            }

            return age;
        }
    }
}
