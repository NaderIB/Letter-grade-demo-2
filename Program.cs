namespace Letter_grade_demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("What grade do you expect to get in ISM 4300: ");
                int grade = int.Parse(Console.ReadLine());

                if (grade >= 98 && grade <= 100)
                {
                    Console.WriteLine("Your letter grade is an A+");
                }
                else if (grade >= 92 && grade < 97)
                {
                    Console.WriteLine("your letter grade is a A");
                }
                else if (grade >= 90 && grade < 91)
                {
                    Console.WriteLine("Your letter grade is a A-");
                }
                else if (grade >= 88 && grade < 89)
                {
                    Console.WriteLine("Your letter grade is a B+");
                }
                else if (grade <= 82 && grade <= 87)
                {
                    Console.WriteLine("Your letter grade is a B");
                }
                else if (grade >= 80 && grade <= 81)
                {
                    Console.WriteLine("Your letter grade is a B-");
                }
                else if (grade >= 78 && grade <= 79)
                {
                    Console.WriteLine("Your letter grade is a C+");
                }
                else if (grade >= 72 && grade <= 77)
                {
                    Console.WriteLine("Your letter grade is a C");
                }
                else if (grade >= 70 && grade <= 71)
                {
                    Console.WriteLine("Your letter grade is a C-");
                }
                else if (grade >= 68 && grade <= 69)
                {
                    Console.WriteLine("Your letter grade is a D+");
                }
                else if (grade >= 62 && grade <= 67)
                {
                    Console.WriteLine("Your letter grade is a D");
                }
                else if (grade >= 60 && grade <= 61)
                {
                    Console.WriteLine("Your letter grade is a D-");
                }
                else if (grade <= 60 && grade >= 0)
                {
                    Console.WriteLine("Your letter grade is an F");
                }
                if (grade <= -1 && grade >= 101)
                {
                    Console.WriteLine("Please enter a valid grade number");
                }
            
        }
    }
}
