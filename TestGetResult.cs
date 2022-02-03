using System;

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
                Console.Error.WriteLine($"Expected result to be 'Woody' but was {0}");
                return false;
            }
        
        }
    }
}