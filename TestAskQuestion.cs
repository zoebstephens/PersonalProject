using System;

namespace PersonalProject
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {
            // TODO(jcollard 2022-02-01): These look great.
            // Now, figure out how to call your methods. In this case you would do the following:
            //
            // 1. Start by setting up a Question object
            // We do this because your method AskQuestion takes 1 parameter which must be a Question
            //
            Question testQuestion = new Question();
            testQuestion.question = "Will Kailey Show up to Class Today?";
            testQuestion.answers.Add("No");
            testQuestion.answers.Add("Yes, She will be late. ");
            testQuestion.answers.Add("She is 'sick' ");
            //
            // Then, create a message to be displayed to the tester. What should the method
            // write to the console when you pass testQuestion as an argument?
            //
            Console.WriteLine("Expected: the output to contain 3 options.");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again.");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.")
            //
             int result = Program.AskQuestion(testQuestion.question);
            //
            // Then we check that the result is equal to 1 because that is what we told the tester to enter.
            // 
            testQuestion = new Question();
            testQuestion.question = "Will Gretchen Pass her Bio Test";
            testQuestion.answers.Add("No");
            testQuestion.answers.Add("Yes, She will be late. ");
            testQuestion.answers.Add("She is 'sick' ");

            Console.WriteLine("Expected: the output to contain 3 options.");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again.");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.")


             int result = Program.AskQuestion(testQuestion.question);

            // Think of a few more tests you could do. What should happen if the question has no answers?
            // What should happen if the question has more than 3 answers?
            return false;

            try
            {
                Program.AskQuestion("NotAnAnswer.txt");

                Console.Error.WriteLine("Expected an exception from loading \"NotAnAnswer.txt\" ");
                return false;

            }

            catch (Exception e)
            {
                // Ignore the Error
            }

            // everyhting seems to be working, so return true 

            return true;

        }
    }
}
