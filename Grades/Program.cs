using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many grades  you want to input: ");
            int numberofgrades = Convert.ToInt32(Console.ReadLine());

            double[] grades = new double[numberofgrades];

            Grades(grades);

            double average = Average(grades);

            

            Console.WriteLine("END OF USER INPUT");

            Console.WriteLine("PROCESSING GRADES....");

            Console.WriteLine($"The average grade is {Average(grades)}, your remarks: {Remarks(average)}");
        }
        public static void Grades(double[] grades)
        {

            for (int counter = 0; counter < grades.Length; counter++)
            {
                Console.Write("Input grade: ");
                double grade = Convert.ToDouble(Console.ReadLine());

                if (grade >= 0 && grade <= 100)
                {
                    grades[counter] = grade;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                    counter--;
                }
            }
        }

        public static double Average(double[] grades)
        
        {
                double sum = 0;

                //access the data in the array and get their sum
                for (int counter = 0; counter < grades.Length; counter++)
                {
                   sum = sum + grades[counter];
                  
                }

            double average = sum / grades.Length;

            return average;
        }

        public static string Remarks(double average)

        {
        
            string remarks =
            average < 50 ? "Failed" :
            average >= 50 && average < 70 ? "Fair" :
            average >= 70 && average < 80 ? "Good" :
            average >= 80 && average < 90 ? "Very Good" :
            average >= 90 && average <= 100 ? "Excellent" : 
            "Invalid Input";

            return remarks;


        }
    }
}
