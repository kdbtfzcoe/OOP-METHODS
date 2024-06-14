namespace IdentifyAge_Pedraya
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                // user input

                Console.Write("Enter year of birth: ");
                int birthYear = Convert.ToInt16(Console.ReadLine());

                int age = CalculateAge(birthYear);
                string generation = DetermineGeneration(age);
                string stage = DetermineLifeStage(age);

                Console.WriteLine($"{age} years old, {generation}, {stage}");
        }

        public static int CalculateAge(int birthYear)
        {
            return 2024 - birthYear;
        }

        public static string DetermineGeneration(int age) 
        {
            string generation = age >= 79 && age <= 96 ? "The Silent Generation" :
                age >= 60 && age <= 78 ? "Baby Boomers" :
                age >= 44 && age <= 59 ? "Gen X" :
                age >= 28 && age <= 43 ? "Millenials" :
                age >= 12 && age <= 27 ? "Gen Z" :
                age >= 0 && age <= 11 ? "Gen Alpha" :
                "";

            return generation;
        }

        public static string DetermineLifeStage(int age)

        {
            string lifestage = age > 80 ? "Late Adulthood" :
                age >= 51 && age <= 80 ? "Mature Adulthood" :
                age >= 36 && age <= 50 ? "Midlife" :
                age >= 21 && age <= 35 ? "Early Adulthood" :
                age >= 12 && age <= 20 ? "Adolescence" :
                age >= 9 && age <= 11 ? "Late Childhood" :
                age >= 7 && age <= 8 ? "Middle Childhood" :
                age >= 4 && age <= 6 ? "Early Childhood" :
                age >= 0 && age <= 3 ? "Infant" :
                "Weird!";

            return lifestage;
        }
    }
}

    
