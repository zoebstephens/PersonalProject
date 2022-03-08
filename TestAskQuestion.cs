using System;

namespace PersonalProject
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {

            Question testQuestion = new Question();
            testQuestion.question = "Will Kailey Show up to Class Today?";
            testQuestion.answers.Add("No");
            testQuestion.answers.Add("Yes, She will be late. ");
            testQuestion.answers.Add("She is 'sick' ");

            Console.WriteLine("Expected: the output to contain 3 options.");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again.");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

            int result = Program.AskQuestion(testQuestion);
            //
            // Then we check that the result is equal to 1 because that is what we told the tester to enter.
            // 


            if (result != 0)
            {
                // When they select 1, the index is 0. If the result is not 0, we fail and display an error message
                Console.Error.WriteLine($"Expected the result to be 0 but it was {result}.");
                return false;
            }

            testQuestion = new Question();
            testQuestion.question = "Will Gretchen Pass her Bio Test";
            testQuestion.answers.Add("No");
            testQuestion.answers.Add("Yes, She will be late. ");
            testQuestion.answers.Add("She is 'sick' ");
            testQuestion.answers.Add("Of course!");


            Console.WriteLine("Expected: the output to contain 4 options.");
            Console.WriteLine("First type 5. This should be an invalid option. It will ask again.");
            Console.WriteLine("Next type 2. This should be a valid option. By selecting 2, the method should return 2."); // TODO(jcollard 2022-02-03): Try asking them to enter a different valid option


            result = Program.AskQuestion(testQuestion);

            if (result != 1)
            {
                // When they select 2, the index is 1. If the result is not 1, we fail and display an error message
                Console.Error.WriteLine($"Expected the result to be 1 but it was {result}.");
                return false;
            }

            testQuestion = new Question();
            testQuestion.question = "Is music playing";

            Console.WriteLine("Expected: the output to contain 0 options.");
            Console.WriteLine("First type 1. This should be an invalid option. It will ask again.");
            Console.WriteLine("Next type enter. This should be a valid option. By selecting enter, the method should move on to the next question.");

            try
            {
                // this should produce an exception
                Program.AskQuestion(testQuestion);

                // if we get to this line that means there was not an exception
                Console.Error.WriteLine($"Expected an exception from loading \"enter\"");
                return false;

            }
            catch (Exception e)
            {
                // Ignore the error
            }

            // everything seems to be working, so return true 
            return true;
        }
    }
}
