using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1768;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder sb = new StringBuilder();

        for (var i = 0; i < Math.Max(word1.Length, word2.Length); i++)
        {
            if (i < word1.Length)
            {
                sb.Append(word1[i]);
            }
            if (i < word2.Length)
            {
                sb.Append(word2[i]);
            }
        }

        return sb.ToString();
    }

    public string MergeAlternately2(string word1, string word2)
    {
        var sb = new StringBuilder();
        int length1 = word1.Length, length2 = word2.Length;
        int minLength = Math.Min(length1, length2);

        for (int i = 0; i < minLength; i++)
        {
            sb.Append(word1[i]).Append(word2[i]);
        }

        if (length1 > minLength) sb.Append(word1.Substring(minLength));
        if (length2 > minLength) sb.Append(word2.Substring(minLength));

        return sb.ToString();
    }

}
