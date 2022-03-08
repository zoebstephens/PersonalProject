using System;
using System.Collections.Generic;

namespace PersonalProject
{
    public class TestGetResult
    {
        public static bool RunTest()
        {
            List<int> scores = new List<int>();
            scores.Add(0);
            scores.Add(4);

            List<string> results = new List<string>();
            results.Add("Kim Kardashian");
            results.Add("Woody");
            string result = Program.GetResult(scores, results);

            if (result != "Woody")
            {
                Console.Error.WriteLine($"Expected result to be 'Woody' but was {result}");
                return false;
            }



            results = new List<string>();
            results.Add("Chair");
            results.Add("Phone");
            results.Add("Soap");

            scores = new List<int>();
            scores.Add(4);
            scores.Add(0);
            scores.Add(3);


            result = Program.GetResult(scores, results);

            if (result != "Chair")
            {
                Console.Error.WriteLine($"Expected result to be 'Chair' but was {result}");
                return false;
            }

            results = new List<string>();
            results.Add("Shoe");
            results.Add("Purse");
            results.Add("Dress");
            results.Add("Glove");

            scores = new List<int>();
            scores.Add(3);
            scores.Add(0);
            scores.Add(3);
            scores.Add(3);


            result = Program.GetResult(scores, results);

            if (result != "Glove")
            {
                Console.Error.WriteLine($"Expected result to be 'Glove' but was {result}");
                return false;
            }

            results = new List<string>();
            results.Add("Kailey");
            results.Add("Gretchen");
            results.Add("Zoe");
            

            scores = new List<int>();
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            
            result = Program.GetResult(scores, results);

            if (result != "Kailey")
            {
                Console.Error.WriteLine($"Expected result to be 'Kailey' but was {result}");
                return false;
            }

            return true;
        }
    }
}