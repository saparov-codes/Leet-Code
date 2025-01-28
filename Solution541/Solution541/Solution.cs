namespace Solution541;

public class Solution
{
    public string ReverseStr(string s, int k)
    {
        char[] chars = s.ToCharArray();
        int n = chars.Length;

        for (int i = 0; i < n; i += 2 * k)
        {
            int left = i;
            int right = Math.Min(i + k - 1, n - 1);

            while (left < right)
            {
                char c = chars[left];
                chars[left] = chars[right];
                chars[right] = c;

                left++;
                right--;
            }
        }

        return new string(chars);
    }

    // mine is 1 ms

    // Leet-Code Answer, After I submit with 0ms

    //public class Solution
    //{
    //    public string ReverseStr(string s, int k)
    //    {
    //        char[] res = s.ToCharArray();
    //        for (int i = 0; i < s.Length; i += (2 * k))
    //        {
    //            Array.Reverse(res, i, Math.Min(k, s.Length - i));
    //        }
    //        return new string(res);
    //    }
    //}
}
