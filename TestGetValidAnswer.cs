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

            answers = new List<string>();
            answers.Add("Banana");
            answers.Add("Cat");
            answers.Add("Lemonade");
            answers.Add("Arizona");
            Console.WriteLine("You should expect to see 4 options: Banana, Cat, Lemonade, and Arizona. Enter 6. This should produce an invalid response. Then enter 3. ");
            result = Program.GetValidAnswer(answers);

            if (result != 2)
            {
                Console.Error.WriteLine($"Expected result to be 2 but was{result}");
                return false;
            }

            answers = new List<string>();
            answers.Add("Chicken");
            answers.Add("Cat");
            answers.Add("Steak");
            answers.Add("Fish");
            Console.WriteLine("You should expect to see 4 options: Chicken, Cat, Steak , and Fish. Enter -5. This should produce an invalid response. Then enter 4. ");
            result = Program.GetValidAnswer(answers);

            if (result != 3)
            {
                Console.Error.WriteLine($"Expected result to be 3 but was{result}");
                return false;
            }

            answers = new List<string>();
            answers.Add("Giraffe");
            answers.Add("Cat");
            answers.Add("Fancy Mouse");
            answers.Add("Hippo");
            Console.WriteLine("You should expect to see 4 options: Giraffe, Cat, Fancy Mouse , and Hippo. Enter Cat. This should produce an invalid response. Then enter 2. ");
            result = Program.GetValidAnswer(answers);

            if (result != 1)
            {
                Console.Error.WriteLine($"Expected result to be 1 but was{result}");
                return false;
            }

            return true;
        }
    }
}