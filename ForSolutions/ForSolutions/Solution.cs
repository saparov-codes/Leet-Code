using System.Text.Json.Serialization;

namespace ForSolutions;

public class Solution
{
    public double MyPow(double x, int n) // 50
    {
        if (x == 0) return 0;
        if (n == 0) return 1;

        long N = n;
        if (N < 0)
        {
            x = 1 / x;
            N = -N;
        }

        double result = 1;
        while (N > 0)
        {
            if (N % 2 == 1)
            {
                result *= x;
            }
            x *= x;
            N /= 2;
        }

        return result;
    }



    public int RomanToInt(string s) // 13
    {
        int sum = 0;
        s = s.ToUpper();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I') sum += 1;
            if (s[i] == 'V') sum += 5;
            if (s[i] == 'X') sum += 10;
            if (s[i] == 'L') sum += 50;
            if (s[i] == 'C') sum += 100;
            if (s[i] == 'D') sum += 500;
            if (s[i] == 'M') sum += 1000;

            if (i + 1 < s.Length)
            {
                if (s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X')) sum -= 2;
                else if (s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C')) sum -= 20;
                else if (s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M')) sum -= 200;
            }
        }
        return sum;
    }

    public int RomanToInt2(string s)
    {
        int sum = 0;
        int n = s.Length;

        for (int i = 0; i < n; i++)
        {
            int current = GetValueForRoman(s[i]);

            if (i + 1 < n && current < GetValueForRoman(s[i + 1]))
            {
                sum -= current;
            }
            else
            {
                sum += current;
            }
        }
        return sum;
    }

    private int GetValueForRoman(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }



    public bool IsArraySpecial(int[] nums) // 3151
    {
        var res = true;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if ((nums[i] % 2 == 0 && nums[i + 1] % 2 == 0) || (nums[i] % 2 != 0 && nums[i + 1] % 2 != 0))
            {
                res = false;
            }
        }

        return res;
    }
}
