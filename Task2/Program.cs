using System;

namespace Task2
{
    class Program
    {
        private const string YES_ANSWER = "Yes";
        private const string NO_ANSWER = "No";
        
        
        static bool IsUserAgree(string message)
        {
            Console.WriteLine(message + $" To answer type '{YES_ANSWER}' or '{NO_ANSWER}'");
            
            while (true)
            {
                var userAnswer = Console.ReadLine();
                if (userAnswer == YES_ANSWER)
                {
                    return true;
                }
                else if (userAnswer == NO_ANSWER)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input try again");
                }
            }
        }


        static void Main(string[] args)
        {
            var userAnswers = new
            {
                IsHomeworkDone = IsUserAgree("Have you done all your homework?"),
                IsTeamProjectDone = IsUserAgree("Did you make a team project?"),
                HasUserUniversityDebt = IsUserAgree("Have you got debt at university?")
            };

            string message = userAnswers switch
            {
                { IsHomeworkDone: true, IsTeamProjectDone: true, HasUserUniversityDebt: false } => "Today you can go for a walk with friends",
                _ => "You still have things to do you can't go out with your friends today"
            };

            Console.WriteLine(message);
        }
    }
}
