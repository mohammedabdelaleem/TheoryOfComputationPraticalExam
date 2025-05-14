# Theory of Computation – Assignment Programs  
Mohammed Abdelaleem Mostafa Abdeldaym  
Section 5  

This repository contains solutions to three core problems in the Theory of Computation subject. All implementations are written in C# (.NET Core).

---

## 📚 Questions Covered

1. ✅ Construct a DFA that accepts all binary strings where the substring 101 appears at least once.  
2. ✅ Write a program that converts a given Context-Free Grammar (CFG) into Greibach Normal Form (GNF).  
3. ✅ Write a program to design a Turing Machine that recognizes the language:  
 L = { Accept binary numbers divisible by 3 }

---

## 💻 Program 3 – Turing Machine (Divisible by 3)

This C# console application simulates a Turing Machine (via Finite State Machine) that checks whether a given binary number is divisible by 3.

It does the following:

- Validates input as a binary number.
- Converts binary to decimal.
- Simulates state transitions to check divisibility by 3.
- Outputs the decimal equivalent and whether it is accepted.

---

## 🧪 Sample Test Cases

| Test # | Binary Input | Decimal Value | Expected Output        |
|--------|--------------|----------------|------------------------|
| TC01   | 0            | 0              | ✅ Accepted             |
| TC02   | 11           | 3              | ✅ Accepted             |
| TC03   | 1001         | 9              | ✅ Accepted             |
| TC04   | 101          | 5              | ❌ Rejected             |
| TC05   | 1110         | 14             | ❌ Rejected             |

---

## 🛠️ How to Run

1. Clone the repository:

```bash
git clone https://github.com/your-username/theory-of-computation-project.git
cd theory-of-computation-project

2. Build and run the project:
dotnet build
dotnet run
