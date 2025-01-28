using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution345;

public class Solution
{
    public string ReverseVowels(string s)
    {
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        char[] chars = s.ToCharArray();

        int left = 0;
        int right = chars.Length - 1;

        while (left < right)
        {
            while (left < right && !vowels.Contains(chars[left]))
            {
                left++;
            }

            while(left < right && !vowels.Contains((char)chars[right]))
            {
                right--;
            }

            if(left < right)
            {
                char c = chars[left];
                chars[left] =chars[right];
                chars[right] = c;
            }

            left++;
            right--;
        }

        return string.Concat(chars);
    }

}
