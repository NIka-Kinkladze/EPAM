public class Method
{
    static int GetMaxUnequalConsecutiveCharacters(string sequence)
    {
        if (string.IsNullOrEmpty(sequence))
            return 0;

        int maxConsecutive = 1;
        int currentConsecutive = 1;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] != sequence[i - 1])
            {
                currentConsecutive++;
            }
            else
            {
                currentConsecutive = 1;
            }

            maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
        }

        return maxConsecutive;
    }

    public static void execution()
    {
        Console.WriteLine("Enter a sequence of symbols:");
        string sequence = Console.ReadLine();

        int maxConsecutive = GetMaxUnequalConsecutiveCharacters(sequence);
        Console.WriteLine($"Maximum unequal consecutive characters: {maxConsecutive}");
    }
}