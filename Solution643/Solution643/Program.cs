namespace Solution643;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Size Array : ");
        var size = int.Parse(Console.ReadLine());
        var array = GetArray(size);
        Console.Write("count of group elements : ");
        var group = int.Parse(Console.ReadLine());

        Solution solution = new Solution();

        var maxAvarage = solution.FindMaxAverage(array, group);
        Console.Write("Maximum Avarage is : " + maxAvarage);

    }

    public static int[] GetArray(int size)
    {
        var array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{i+1}-Number : ");
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}
