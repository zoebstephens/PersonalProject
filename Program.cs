using System;
using System.Collections.Generic;

namespace PersonalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks if the user added a command line argument
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // Exits the program 
            }

            // Otherwise, the program continues executing

            List<int> scores = new List<int>();
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);

            Question Quality = new Question();
            Quality.question = "What Quality Makes for the Perfect Villain?";
            Quality.answers.Add("Brilliance");
            Quality.answers.Add("Cold-Hearted");
            Quality.answers.Add("Manipulative");
            Quality.answers.Add("Dramatic");

            int result = Program.AskQuestion(Quality);
            scores[result] = scores[result] + 1;


            Question Description = new Question();
            Description.question = "Which Color Suits a Villain Best?";
            Description.answers.Add("Red");
            Description.answers.Add("Pattern");
            Description.answers.Add("Purple");
            Description.answers.Add("Black");

            Program.AskQuestion(Description);
            scores[result] = scores[result] + 1;


            Question Color = new Question();
            Color.question = "How Would People Describe You?";
            Color.answers.Add("Cunning");
            Color.answers.Add("Sneaky");
            Color.answers.Add("Selfish");
            Color.answers.Add("Dimwitted");

           AskQuestion(Color);
           scores[result] = scores[result] + 1;


            Question Motivation = new Question();
            Motivation.question = "What motivates you?";
            Motivation.answers.Add("Total Destruction");
            Motivation.answers.Add("Achievement");
            Motivation.answers.Add("Popularity");
            Motivation.answers.Add("Total Control");

            Program.AskQuestion(Motivation);
            scores[result] = scores[result] + 1;

            List<string> results = new List<string>();
            results.Add("Satan");
            results.Add("Gru");
            results.Add("Kailey");
            results.Add("Doofenshmirtz");
            GetResult(scores, results);



        }

        public static void TestAll()
        {
            bool testAskQuestion = TestAskQuestion.RunTest();
            Console.WriteLine($"Test AskQuestion(question) : {testAskQuestion}");

            bool testGetResult = TestGetResult.RunTest();
            Console.WriteLine($"Test GetResult(scores, results) : {testGetResult}");

            bool testGetValidAnswer = TestGetValidAnswer.RunTest();
            Console.WriteLine($"Test GetValidAnswer(answers) : {testGetValidAnswer}");

        }

        /// <summary>
        /// This displays the question, the list of answers and waits for the user to input a valid answer. 
        /// </summary>
        /// <param name="Question"></param>
        /// <returns></returns>
        public static int AskQuestion(Question question)
        {
            if (question == null)
            {
                throw new ArgumentNullException("Question can not be null");

            }

            List<string> answers = question.answers;

            if (answers.Count == 0)
            {
                throw new ArgumentException("The question must contain at least 1 option");
            }

            int ix = 1;
            foreach (string answer in answers)
            {
                Console.WriteLine($"{ix}. {answer}");
                ix = ix + 1;
            }

            // Display Question
            // Loop through each answer and display it 
            // Use GetValidAnswer method to get the user's response
            return GetValidAnswer(question.answers);
        }

        /// <summary>
        /// </summary>
        /// <param name="answers"></param>
        /// <returns></returns>
        public static int GetValidAnswer(List<string> answers)
        {
            // Validate that there is at least 1 possible answer.
            // If the list of answers is empty, throw an exception
            // Otherwise, Display a message asking the user to select an option.
            // Store the user's response in a variable name choice
            // Validate that choice is one of the possible answers
            // If it is not a valid answer
            // Display an error message
            // Go to 3
            // Otherwise, return the user's choice.
            if (answers.Count == 0)
            {
                throw new Exception($"At least one possible answer does not exist.");
            }

            Console.WriteLine("Select an Option");
            int userChoice;

            do
            {
                Console.Write($"Enter a number between 1 and {answers.Count}: ");
                string input = Console.ReadLine();

                bool isANumber = int.TryParse(input, out userChoice);

                if (isANumber == false)
                {
                    Console.Error.WriteLine("You did not enter a valid number.");
                }
                else if (userChoice < 1)
                {
                    Console.Error.WriteLine("That number is not greater than 1.");
                }
                else if (userChoice > answers.Count)
                {
                    Console.Error.WriteLine($"That number is not less than {answers.Count}.");
                }
            }
            while (userChoice < 1 || userChoice > answers.Count);

            return userChoice -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scores"></param>
        /// <param name="results"></param>
        /// <returns></returns>
        public static string GetResult(List<int> scores, List<string> results)

            {
                if (scores == null || results == null) throw new Exception("Scores List and Results list must be non-null.");
                if (scores.Count == 0) throw new Exception("Cannot process an empty list.");
                if (results.Count != scores.Count) throw new Exception("scores and results lists were not the same length.");

                int highestscore = scores[0];
                string highestresult = results[0];

                int index = 0;
                foreach (int score in scores)
                {
                    if (score > highestscore)
                    {
                        highestscore = scores[index];
                        highestresult = results[index];
                    }

                    index = index + 1;
                }
                Console.WriteLine($"You are {highestresult}");
                return highestresult;
            }
        

    

        /// <summary>
        /// Given a prompt to show to the user, displays the prompt then reads
        /// input from the keyboard until the user picks a character. If
        /// the user does not choose a character, this method displays an error
        /// message and prompts the user again.
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>whatever letter +1 the user chose</returns>


    }

    class Question
    {
        public string question;
        public List<string> answers = new List<string>();
    }
}
