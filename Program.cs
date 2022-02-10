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

            Question Quality = new Question();
            Quality.question = "What Quality Makes for the Perfect Villain?";
            Quality.answers.Add("Brilliance");
            Quality.answers.Add("Cold-Hearted");
            Quality.answers.Add("Manipulative");
            Quality.answers.Add("Dramatic");

            Console.WriteLine(Quality.question);

            Console.WriteLine($"1. {Quality.answers[0]}");
            Console.WriteLine($"2. {Quality.answers[1]}");
            Console.WriteLine($"3. {Quality.answers[2]}");
            Console.WriteLine($"4. {Quality.answers[3]}");


            Question Description = new Question();
            Description.question = "Which Color Suits a Villain Best?";
            Description.answers.Add("Red");
            Description.answers.Add("Pattern");
            Description.answers.Add("Purple");
            Description.answers.Add("Black");

            Console.WriteLine(Description.question);

            Console.WriteLine($"1. {Description.answers[0]}");
            Console.WriteLine($"2. {Description.answers[1]}");
            Console.WriteLine($"3. {Description.answers[2]}");
            Console.WriteLine($"4. {Description.answers[3]}");


            Question Color = new Question();
            Color.question = "How Would People Describe You?";
            Color.answers.Add("Cunning");
            Color.answers.Add("Sneaky");
            Color.answers.Add("Selfish");
            Color.answers.Add("Dimwitted");

            Console.WriteLine(Color.question);

            Console.WriteLine($"1. {Color.answers[0]}");
            Console.WriteLine($"2. {Color.answers[1]}");
            Console.WriteLine($"3. {Color.answers[2]}");
            Console.WriteLine($"4. {Color.answers[3]}");


            Question Motivation = new Question();
            Motivation.question = "What motivates you?";
            Motivation.answers.Add("Total Destruction");
            Motivation.answers.Add("Achievement");
            Motivation.answers.Add("Popularity");
            Motivation.answers.Add("Total Control");

            Console.WriteLine(Motivation.question);

            Console.WriteLine($"1. {Motivation.answers[0]}");
            Console.WriteLine($"2. {Motivation.answers[1]}");
            Console.WriteLine($"3. {Motivation.answers[2]}");
            Console.WriteLine($"4. {Motivation.answers[3]}");


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
        /// 
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
            int userChoice = GetValidAnswer(answers);
            return userChoice;
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
            // Initialize highest to 0. This variable represents the highest score we have seen so far.
            // Initialize highestIx to 0. This variable represents the index of the highest score we have seen so far.
            // Loop through each score in scores, tracking the index in a variable currentIx
            // If the score is greater than the highest score
            // Update highest to store the score (this is the highest score we have seen so far)
            // Update highestIx to store the currentIx (this is the index of the highest score we have seen so far)
            // After we have checked each score, highestIx should be the index of the highest score.
            // return results[highestIx];

            // TODO(jcollard 2022-02-10): This is a tricky method to write. Each
            // of the lists is associated with the other. I've created an
            // example showing how to use a foreach loop to search a list for a
            // value. You can find it here:
            // https://jcollard.github.io/IntroToCSharpSite/examples/association-list

            return null;
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
