namespace Solution88;

public class Solution
{
    public int[] SortedMergedArray(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1;
        int p2 = n - 1;
        int p = m + n;

        int[] array = new int[p];
        if (p1 >= 0 && p2 >= 0)
        {
            for (int i = 0; i <= p1; i++)
            {
                array[i] = nums1[i];
            }
            for (int i = 0; i <= p2; i++)
            {
                array[i + p1] = nums2[i];
            }
        }
        else
        {
            throw new Exception("Check Your Number Format !");
        }
        Array.Sort(array);


        return array;
    }

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1;
        int p2 = n - 1; 
        int p = m + n - 1;

        while (p1 >= 0 && p2 >= 0)
        {
            if (nums1[p1] > nums2[p2])
            {
                nums1[p--] = nums1[p1--];
            }
            else
            {
                nums1[p--] = nums2[p2--];
            }
        }

        while (p2 >= 0)
        {
            nums1[p--] = nums2[p2--];
        }
    }

    public void MergeByLeetCode(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0 && n != 0)
        {
            Array.Copy(nums2, 0, nums1, 0, n);
            return;
        }
        else if ((m != 0 && n == 0) || (m == 0 && n == 0))
            return;
        int[] result = new int[m + n];
        int index1 = 0;
        int index2 = 0;
        while (index1 < m || index2 < n)
        {
            if (index1 == m)
            {
                result[m + index2] = nums2[index2];
                index2++;
            }
            else if (index2 == n)
            {
                result[index1 + n] = nums1[index1];
                index1++;
            }
            else if (nums1[index1] > nums2[index2])
            {
                result[index1 + index2] = nums2[index2];
                index2++;
            }
            else
            {
                result[index1 + index2] = nums1[index1];
                index1++;
            }
        }
        Array.Copy(result, 0, nums1, 0, m + n);
        return;
    }


}
