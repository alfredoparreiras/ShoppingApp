namespace AtlasShoppingConsole.Utility
{
    public class Validations
    {
        public static int ValidateInt()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                    return number;
                Console.WriteLine($" Error{input} is not valid");
            }
        }

        public static decimal ValidateDecimal(string input)
        {
            while (true)
            {
                if (decimal.TryParse(input, out decimal number))
                    return number;
                Console.WriteLine($" Error{input} is not valid");
            }
        }

        public static double ValidateDouble()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                    return number;
                Console.WriteLine($" Error{input} is not valid");
            }
        }

        public static string ValidateString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException("Input is null or contain only whitespace");
            if (input.Length == 0)
                throw new ArgumentException("This input is required.");

            return input;
        }
        public static string ValidateStringWithInput()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException("Input is null or contain only whitespace");
            if (input.Length == 0)
                throw new ArgumentException("This input is required.");

            return input;
        }
    }
}
