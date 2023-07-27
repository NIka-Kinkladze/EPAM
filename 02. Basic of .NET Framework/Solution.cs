namespace Solutions
{
    namespace Solutions
    {
        public class Solution
        {
            public static void mainmethod()
            {
                Console.Write("Enter a decimal number: ");
                string decimalString = Console.ReadLine(); // Read the decimal number as a string from the user

                Console.Write("Enter the base to convert to (between 2 and 20): ");
                string baseString = Console.ReadLine(); // Read the new base number system as a string from the user

                int num, baseNum;

                // Parse the input decimal number
                if (!int.TryParse(decimalString, out num))
                {
                    Console.WriteLine("Error: Input must be an integer");
                    return;
                }

                // Parse the new base number system
                if (!int.TryParse(baseString, out baseNum) || baseNum < 2 || baseNum > 20)
                {
                    Console.WriteLine("Error: Base must be an integer between 2 and 20");
                    return;
                }

                // Convert the decimal number to the new base and get the result as a string
                string result = DecimalToBase(num, baseNum);

                Console.WriteLine("Result: " + result); // Print the result to the console
            }

            // Method to convert a decimal number to a new base
            static string DecimalToBase(int num, int baseNum)
            {
                string digits = "0123456789ABCDEFGHIJ"; // Digits used for bases up to 20
                string result = "";

                while (num > 0)
                {
                    int digit = num % baseNum; // Get the remainder, which represents the rightmost digit in the new base
                    result = digits[digit] + result; // Prepend the digit to the result string
                    num /= baseNum; // Divide the number by the base to remove the rightmost digit
                }

                return result; // Return the converted number as a string in the new base
            }
        }
    }
}