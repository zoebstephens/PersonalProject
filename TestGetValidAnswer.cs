using System;
using System.Collections.Generic;

namespace PersonalProject
{
    class TestGetValidAnswer
    {
        public static bool RunTest()
        {
            List<string> answers = new List<string>();
            answers.Add("Banana");
            answers.Add("Cat");
            Console.WriteLine("You should expect to see 2 options: Banana and Cat. Enter 5. This should produce an invalid response. Then enter 2. ");
            int result = Program.GetValidAnswer(answers);

            if (result != 1)
            {
                Console.Error.WriteLine($"Expected result to be 1 but was{result}");
                return false;
            }

            // TODO (jcollard 2022-02-03): Write a few more test cases here. What should happen with a list with 4 answers?
            // What are some other invalid answers the user could enter? What about '-5' or 'Cat'?


            return true;
        }
    }
}