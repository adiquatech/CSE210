using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string percentage = Console.ReadLine();
        int gradePercentage = int.Parse(percentage);
        {
            string letter = "";
            string sign = "";

            if (gradePercentage >= 90)
            {
                letter = "A";
                if (gradePercentage == 100)
                {
                    sign = "";
                }
                else if (gradePercentage % 10 >= 7)
                {
                    sign = "";
                }
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
                if (gradePercentage % 10 >= 7)
                {
                    sign = "+";
                }
                else if (gradePercentage % 10 < 3)
                {
                    sign = "-";
                }
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
                if (gradePercentage % 10 >= 7)
                {
                    sign = "+";
                }
                else if (gradePercentage % 10 < 3)
                {
                    sign = "-";
                }
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
                if (gradePercentage % 10 >= 7)
                {
                    sign = "+";
                }
                else if (gradePercentage % 10 < 3)
                {
                    sign = "-";
                }
            }
            else
            {
                letter = "F";
                sign = "";
            }

            string finalGrade = $"{letter}{sign}";
            Console.WriteLine($"Your letter grade is: {finalGrade}");

            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Better luck next time. Keep working hard!");
            }
        }
    }
}