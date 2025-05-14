namespace DFA101;

public enum State
{
	q0,
	q1,
	q2,
	q3 // Accepting state
}

public class DFA
{
	private State currentState;

	public DFA()
	{
		currentState = State.q0;
	}

	public void Reset()
	{
		currentState = State.q0;
	}

	public bool Process(string input)
	{
		Reset();

		foreach (char ch in input)
		{
			if (ch != '0' && ch != '1')// Not A binary string 
			{
				throw new ArgumentException("Input must only contain '0' or '1'");
			}

			currentState = GetNextState(currentState, ch);
		}

		return currentState == State.q3;
	}

	private State GetNextState(State state, char input)
	{
		switch (state)
		{
			// q0  q1  
			case State.q0:
				return input == '0' ? State.q0 : State.q1;
			case State.q1:
				return input == '0' ? State.q2 : State.q1;
			case State.q2:
				return input == '0' ? State.q0 : State.q3;
			case State.q3:
				return State.q3; // Once accepted, stay in accepting
			default:
				throw new InvalidOperationException("Invalid state");
		}
	}
}
