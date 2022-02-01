using System;

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



        }
    }
}