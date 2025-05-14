using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_3;
public static class Utils
{
	enum State { Q0, Q1, Q2 }

	public static bool IsDivisibleBy3(string binary)
	{
		State currentState = State.Q0;

		foreach (char symbol in binary)
		{
			if (symbol != '0' && symbol != '1')
			{
				throw new ArgumentException("Invalid binary digit: " + symbol);
			}

			switch (currentState)
			{
				case State.Q0:
					currentState = (symbol == '0') ? State.Q0 : State.Q1;
					break;
				case State.Q1:
					currentState = (symbol == '0') ? State.Q2 : State.Q0;
					break;
				case State.Q2:
					currentState = (symbol == '0') ? State.Q1 : State.Q2;
					break;
			}
		}

		return currentState == State.Q0; // Accept if in state Q0
	}

	public static int BinaryToDecimal(string binary)
	{
		if (string.IsNullOrEmpty(binary) || !binary.All(c => c == '0' || c == '1'))
			throw new ArgumentException("Input must be a binary string (only 0s and 1s).");

		return Convert.ToInt32(binary, 2);
	}
}
