using System;
using System.Collections.Generic; 

namespace PersonalProject
{
    class Program
    {
        static void Main(string[] args)
        {

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Question"></param>
        /// <returns></returns>
        public static int AskQuestion(String Question)
        {
            // Display Question
            // Loop through each answer and display it 
            // Use GetValidAnswer method to get the user's response
            return -1;
        }

        /// <summary>
        /// 
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
            return -1;
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
