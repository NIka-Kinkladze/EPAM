using System;

public class StringUtil
{
    // Method to count the maximum number of consecutive unequal characters in a string
    public static int MaxConsecutiveUnequalChars(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }

    // Method to count the maximum number of consecutive identical letters of the Latin alphabet
    public static int MaxConsecutiveLatinLetters(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]) && char.IsLetter(input[i - 1]) && input[i] == input[i - 1])
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }

    // Method to count the maximum number of consecutive identical digits
    public static int MaxConsecutiveDigits(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]) && char.IsDigit(input[i - 1]) && input[i] == input[i - 1])
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }
}
