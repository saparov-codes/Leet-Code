namespace Solution541;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Text : ");
        var text = Console.ReadLine();
        Console.Write("Count : ");
        var count = int.Parse(Console.ReadLine());

        Solution solution = new Solution();

        var res = solution.ReverseStr(text, count);
        Console.WriteLine(res);
    }
}
