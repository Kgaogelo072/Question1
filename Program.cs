using System;
using System.Linq;


public class LongestSentanceAnswer

{       static void Main()
    {
        Console.WriteLine(Solution());

    }
        public static int Solution()
        {
            //string s = "We test coders. Give us a try?"
            string s = "Forget CSs..Save time .xx";
            string[] sentences = s.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLength = 0;
            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int sentenceLength = words.Length;
                if (sentenceLength > maxLength)
                {
                    maxLength = sentenceLength;
                }
            }
            return maxLength;
        }
}

