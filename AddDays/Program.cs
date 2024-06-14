using System;


namespace AddDays_Pedraya
{
        internal class Program
        {
        public static void Main(string[] args)
        {
            // lahat ng method dito icacall at ipriprint

            Console.Write("Enter a number between 1 to 7: ");
            int dayNumber = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine(Display(dayNumber));

            int finalDay = AddDays(dayNumber);

            Console.WriteLine(FinalDay(finalDay));
            
        }

        public static string Display(int dayNumber)
        {
  
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string message = dayNumber >= 1 && dayNumber <= 7 ? $"The day is {days[dayNumber - 1]}" : "Invalid Input!";

            return message;
        }

        public static int AddDays(int dayNumber)

        {
            Console.Write("Input number to add to the day: ");
            int dayToAdd = Convert.ToInt16(Console.ReadLine());
            int finalDay = (dayNumber + dayToAdd) % 7;
            return finalDay;
        }

        public static string FinalDay(int finalDay)
        {
            string[] addDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            
            string message = finalDay > 1 ? $"The day is {addDays[finalDay - 1]}" : "Invalid Input!";
            

            return message;
        }
            
    }
}