namespace Solution1768;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("First word : ");
        var word1 = Console.ReadLine();
        Console.Write("Second word : ");
        var word2 = Console.ReadLine();

        Solution s = new Solution();
        var res = s.MergeAlternately(word1, word2);
        Console.WriteLine("Result : " + res);

    }
}
