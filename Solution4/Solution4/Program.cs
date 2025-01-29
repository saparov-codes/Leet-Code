namespace Solution4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("First array size : ");
        var size1 = int.Parse(Console.ReadLine());
        var array1 = GetArray(size1);

        Console.Write("Second array size : ");
        var size2 = int.Parse(Console.ReadLine());
        var array2 = GetArray(size2);

        Solution solution = new Solution();
        var average = solution.FindMedianSortedArrays(array1, array2);

        Console.WriteLine("Average : " + average);
    }

    public static int[] GetArray (int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{i+1}-Number : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }
}
