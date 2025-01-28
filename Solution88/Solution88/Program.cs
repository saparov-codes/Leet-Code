namespace Solution88;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("First Array Size : ");
        var size1 = int.Parse(Console.ReadLine());
        var array1 = GetArray(size1);
        Console.Write("Second Array Size : ");
        var size2 = int.Parse(Console.ReadLine());
        var array2 = GetArray(size2);

        Console.Write("Get First(count) : ");
        var count1 = int.Parse(Console.ReadLine());
        Console.Write("Get Second(count) : ");
        var count2 = int.Parse(Console.ReadLine());

        Solution solution = new Solution();
        solution.MergeByLeetCode(array1, count1, array2, count2);

        Console.WriteLine("Result!");
        Console.WriteLine(string.Join(", ", array1));

    }

    public static int[] GetArray(int size)
    {
        int[] ints = new int[size];
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write($"{i + 1}-Number :");
            ints[i] = int.Parse(Console.ReadLine());
        }

        return ints;
    }
}
