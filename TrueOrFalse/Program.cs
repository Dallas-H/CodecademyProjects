using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            // Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[] { "Are you a human", "Is the sky key is red", "Do girls fart" };
            bool[] answers = new bool[] { true, false, true };

            RunQuiz(questions,answers);
        }
        static void RunQuiz(string[] questions, bool[]answers)
        {
            string[] responses = new string[questions.Length];

            //Checks if you have the same amount of questions to answers
            if (questions.Length > answers.Length)
            {
                Console.WriteLine("You are missing an answer to on of your questions.");
            }
            else if (questions.Length < answers.Length)
            {
                Console.WriteLine("You are missing an question to on of your answers.");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(questions[askingIndex]);
                Console.WriteLine("True or False");

                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
                while (isBool == false)
                {
                    Console.WriteLine("Pleaes enter True or False");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = input;
                askingIndex++;
            }
            Console.WriteLine();
            /*
            foreach (string response in responses)
            {
                Console.WriteLine(response);
            }
            */
            int scoringIndex = 0;
            int score = 0;

            foreach (string response in responses)
            {
                Console.WriteLine($"Input: {response} | Answer: {answers[scoringIndex]}");
                string check = answers[scoringIndex].ToString().ToLower();
                if (response == check)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of {scoringIndex}correct");
        }
    }
}
