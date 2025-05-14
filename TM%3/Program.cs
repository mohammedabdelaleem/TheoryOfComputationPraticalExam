using TM_3;

char again = 'n';

do
{
	try
	{
		Console.Clear();

		Console.Write("Enter a binary number:");
		string input = Console.ReadLine();

		int decimalValue = Utils.BinaryToDecimal(input);
		bool isDivisible = Utils.IsDivisibleBy3(input);

		Console.Write($"Decimal value: {decimalValue}\n");
		Console.WriteLine(isDivisible
			? " Accepted: Number is divisible by 3.\n"
			: " Rejected: Number is not divisible by 3.\n");
	}
	catch (ArgumentException ex)
	{
		Console.WriteLine("Error: " + ex.Message);
	}

	Console.Write("Try Again? [Y | N] : ");
	again = char.Parse(Console.ReadLine().Substring(0, 1));
} while (char.ToUpper(again) == 'Y');