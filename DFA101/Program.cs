using DFA101;

DFA dfa = new DFA();

Console.WriteLine("Enter a binary string (or type 'exit' to quit):");

while (true)
{
	Console.Write("> ");
	string input = Console.ReadLine();

	if (input?.ToLower() == "exit")
		break;

	try
	{
		bool result = dfa.Process(input);
		Console.WriteLine(result
			? "Accepted: The string contains '101'"
			: "Rejected: The string does not contain '101'");
	}
	catch (Exception ex)
	{
		Console.WriteLine($"Error: {ex.Message}");
	}
}