
using Automata_dll;

var cfg = new Grammar();
cfg.AddProduction("S", new List<string> { "AB", "b" });
cfg.AddProduction("A", new List<string> { "a", "S" });
cfg.AddProduction("B", new List<string> { "b" });

Console.WriteLine("Original Grammar:");
cfg.Print();

Console.WriteLine("\nStep 1: Remove Unit Productions");
cfg.RemoveUnitProductions();
cfg.Print();

Console.WriteLine("\nStep 2: Convert to GNF");
cfg.ConvertToGNF();
cfg.Print();

