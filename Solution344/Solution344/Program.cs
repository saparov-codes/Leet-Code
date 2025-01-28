namespace Solution344;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter chars Count : ");
        var count = int.Parse(Console.ReadLine());
        var charArray = GetCharArray(count);

        Solution solution = new Solution();
        solution.ReverseString(charArray);
        foreach (char c in charArray)
        {
            Console.Write(string.Concat(c, ", "));
        }
    }

    public static char[] GetCharArray(int size)
    {
        char[] array = new char[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{i + 1}-Char : ");
            array[i] = char.Parse(Console.ReadLine());
        }

        return array;
    }
}
