
namespace Automata_dll;

public class Grammar
{
	public Dictionary<string, List<string>> Productions = new();

	public void AddProduction(string lhs, List<string> rhsList)
	{
		if (!Productions.ContainsKey(lhs))
			Productions[lhs] = new List<string>();

		foreach (var rhs in rhsList)
			Productions[lhs].Add(rhs);
	}

	public void Print()
	{
		foreach (var rule in Productions)
		{
			Console.WriteLine($"{rule.Key} -> {string.Join(" | ", rule.Value)}");
		}
	}

	public void RemoveUnitProductions()
	{
		bool changed;
		do
		{
			changed = false;
			var newProductions = new Dictionary<string, List<string>>();

			foreach (var (lhs, rhsList) in Productions)
			{
				var newList = new List<string>();

				foreach (var rhs in rhsList)
				{
					if (rhs.Length == 1 && Char.IsUpper(rhs[0]))
					{
						changed = true;
						var nonTerminal = rhs;
						if (Productions.ContainsKey(nonTerminal))
							newList.AddRange(Productions[nonTerminal]);
					}
					else
					{
						newList.Add(rhs);
					}
				}

				newProductions[lhs] = newList.Distinct().ToList();
			}

			Productions = newProductions;
		} while (changed);
	}

	public void ConvertToGNF()
	{
		var gnf = new Dictionary<string, List<string>>();

		foreach (var (lhs, rhsList) in Productions)
		{
			gnf[lhs] = new List<string>();

			foreach (var rhs in rhsList)
			{
				if (!string.IsNullOrEmpty(rhs) && Char.IsLower(rhs[0]))
				{
					gnf[lhs].Add(rhs);
				}
				else if (rhs.Length > 1 && Char.IsUpper(rhs[0]))
				{
					var first = rhs[0].ToString();
					if (Productions.ContainsKey(first))
					{
						foreach (var sub in Productions[first])
						{
							if (Char.IsLower(sub[0]))
							{
								var newRule = sub + rhs.Substring(1);
								gnf[lhs].Add(newRule);
							}
						}
					}
				}
			}

			gnf[lhs] = gnf[lhs].Distinct().ToList();
		}

		Productions = gnf;
	}
}