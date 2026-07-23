using System;
class Program
{
    static void PredictStudentScore()
    {
        double attendance = GetValidatedDetails("Enter Attendance (%): ", 0, 100);
        double assignment = GetValidatedDetails("Enter Assignment (%): ", 0, 100);
        double quiz = GetValidatedDetails("Enter Quiz (%): ", 0, 100);
        double studyHours = GetValidatedDetails("Enter Study Hours (hours): ", 0, 24);
        Student student = new Student(attendance, assignment, quiz, studyHours);
        student.DisplayInfo();
    }

    static double GetValidatedDetails(string prompt, double min, double max)
    {

    while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double value))
            {
                Console.WriteLine("Error: Input must be a valid number.\n");
            }
            else if (value < min)
            {
                Console.WriteLine($"Error: Value cannot be less than {min}.\n");
            }
            else if (value > max)
            {
                Console.WriteLine($"Error: Value cannot be greater than {max}.\n");
            }
            else
            {
                return value;
            }
        }
    }

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "2")
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("  Student Prediction System");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("1. Predict Student Score");
            Console.WriteLine("2. Exit");
            Console.Write("Enter choice: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PredictStudentScore();
                    break;
                case "2":
                    Console.WriteLine("Thank you.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}
