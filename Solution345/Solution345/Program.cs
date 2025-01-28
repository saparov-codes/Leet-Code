namespace Solution345;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Your text : ");
        var text = Console.ReadLine();

        Solution solution = new Solution();
        var res = solution.ReverseVowels(text);
        Console.WriteLine("Result : " + res);
    }
}
