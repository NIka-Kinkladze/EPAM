public class Method
{
    // Method to calculate the maximum number of unequal consecutive characters in the given sequence
    static int GetMaxUnequalConsecutiveCharacters(string sequence)
    {
        // If the sequence is empty or null, there are no consecutive characters
        if (string.IsNullOrEmpty(sequence))
            return 0;

        int maxConsecutive = 1; // Initialize the maximum consecutive count to 1 (since at least one character is required)
        int currentConsecutive = 1; // Initialize the current consecutive count to 1 (since the first character always starts with 1)

        // Loop through the sequence starting from the second character (index 1)
        for (int i = 1; i < sequence.Length; i++)
        {
            // Check if the current character is different from the previous character
            if (sequence[i] != sequence[i - 1])
            {
                currentConsecutive++; // If unequal, increment the current consecutive count
            }
            else
            {
                // If the characters are equal, reset the current consecutive count to 1
                // This ensures that only consecutive unequal characters are counted
                currentConsecutive = 1;
            }

            // Update the maximum consecutive count by taking the maximum between the current and previous maximum
            maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
        }

        return maxConsecutive; // Return the maximum unequal consecutive characters
    }

    public static void execution()
    {
        Console.WriteLine("Enter a sequence of symbols:");
        string? sequence = Console.ReadLine(); // Read the input sequence from the user

        int maxConsecutive = GetMaxUnequalConsecutiveCharacters(sequence); // Call the method to get the maximum unequal consecutive characters
        Console.WriteLine($"Maximum unequal consecutive characters: {maxConsecutive}"); // Print the result to the console
    }
}