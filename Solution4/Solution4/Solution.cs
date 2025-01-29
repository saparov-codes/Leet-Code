namespace Solution4;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var sortedArray = new int[nums1.Length + nums2.Length];

        Array.Copy(nums1, sortedArray, nums1.Length);
        Array.Copy(nums2, 0, sortedArray, nums1.Length, nums2.Length);

        Array.Sort(sortedArray);

        int length = sortedArray.Length;
        if (length % 2 == 0)
        {
            return (sortedArray[length / 2 - 1] + sortedArray[length / 2]) / 2.0;
        }
        else
        {
            return sortedArray[length / 2];
        }
    }


    // Chat GPT pastdagi 0 ms da ishlaydi, meniki yuqoridagi 11 ms da ishladi

    public double FindMedianSortedArrays1(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            var temp = nums1;
            nums1 = nums2;
            nums2 = temp;
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int left = 0, right = m;

        while (left <= right)
        {
            int partition1 = (left + right) / 2;
            int partition2 = (m + n + 1) / 2 - partition1;

            int maxLeft1 = (partition1 == 0) ? int.MinValue : nums1[partition1 - 1];
            int maxLeft2 = (partition2 == 0) ? int.MinValue : nums2[partition2 - 1];

            int minRight1 = (partition1 == m) ? int.MaxValue : nums1[partition1];
            int minRight2 = (partition2 == n) ? int.MaxValue : nums2[partition2];

            if (maxLeft1 <= minRight2 && maxLeft2 <= minRight1)
            {
                if ((m + n) % 2 == 0)
                {
                    return (Math.Max(maxLeft1, maxLeft2) + Math.Min(minRight1, minRight2)) / 2.0;
                }
                else
                {
                    return Math.Max(maxLeft1, maxLeft2);
                }
            }
            else if (maxLeft1 > minRight2)
            {
                right = partition1 - 1;
            }
            else
            {
                left = partition1 + 1;
            }
        }

        throw new ArgumentException("Input arrays are not sorted.");
    }

}

