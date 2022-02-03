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
            string result = Program.GetResult(scores,results);

            if (result != "Woody")
            {
                Console.Error.WriteLine($"Expected result to be 'Woody' but was {result}");
                return false;
            }

            // TODO(jcollard 2022-02-03): Add a few more examples.
            // 1. Create a new scores list with 3 scores. What does that test look like?
            // 2. Create a new scores list with 4 scores. What does that test look like?


            return true;
        
        }
    }
}