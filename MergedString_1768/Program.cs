using System;
namespace MergedString_1768;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        List<char> merged = new List<char>();
        int i = 0;
        int j = 0;

        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length)
            {
                merged.Add(word1[i]);
                i++;
            }

            if (j < word2.Length)
            {
                merged.Add(word2[j]);
                j++;
            }
        }

        return new string(merged.ToArray());
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string word1 = "abc";
        string word2 = "pqr";
        string result = solution.MergeAlternately(word1, word2);
        Console.WriteLine(result);
    }
}