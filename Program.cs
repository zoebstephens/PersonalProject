using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-27): This line makes it so you can use the List data type.
// using List; 

namespace PersonalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Feedback(jcollard 2022-01-27): 
            // Here is an example of how you would create a question:
            
            // First create a new Question()
            Question simpleQuestion = new Question();

            // Next, set the question to be an actual question.
            simpleQuestion.question = "How much wood could a woodchuck chuck if a woodchuck could chuck wood?";

            // Next, add answers to the question
            simpleQuestion.answers.Add("As much wood as a woodchuck could chuck if a woodchuck could chuck wood.");
            simpleQuestion.answers.Add("Uh... 14?");
            simpleQuestion.answers.Add("None. Clearly the woodchuck is a manifestation of all your fears.");

            // Finally, you can display the question and answers
            Console.WriteLine(simpleQuestion.question);

            // For your final solution, you will loop through these rather than manually selecting each one.
            Console.WriteLine($"1. {simpleQuestion.answers[0]}");
            Console.WriteLine($"2. {simpleQuestion.answers[1]}");
            Console.WriteLine($"3. {simpleQuestion.answers[2]}");

        }

        // TODO(jcollard 2022-01-27): Add a documentation comment
        public static int AskQuestion(String Question)
        {
            // Display Question
            // Loop through each answer and display it 
            // Use GetValidAnswer method to get the user's response
            return -1;
        }

        // TODO(jcollard 2022-01-27): Add a documentation comment
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

        // TODO(jcollard 2022-01-27): Add a documentation comment
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

    // Feedback(jcollard 2022-01-27): I've added in the Question class for you.
    // This class stores both a question string and a list of answers together!
    class Question 
    {
        public string question;
        public List<string> answers = new List<string>();
    }
}
