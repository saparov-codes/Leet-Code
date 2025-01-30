namespace Solution643;

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        if (k <= 0 || k > nums.Length)
        {
            throw new ArgumentException("group elements must be positive and less than Array size!");
        }

        var sum = 0d;
        for (int i = 0;i < k; i++)
        {
            sum += nums[i];
        }
        var max = sum;

        for (int i = k; i < nums.Length;i++)
        {
            sum = sum - nums[i - k] + nums[i];
            max = Math.Max(max, sum);
        }
        

        return max / k;
    }
}
