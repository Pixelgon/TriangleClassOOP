using System;
using TriangleV2;

namespace Class
{
    internal class Program
    {
        public static Double ReadDouble(string prompt)
        {
            Double cislo;
            Console.Write(prompt);
            // Dokud neni vstup cislo
            while (!Double.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Neplatný vstup");
                Console.Write(prompt);
            }

            Console.Clear();
            return cislo;
        }
        public static void Main(string[] args)
        {
            Triangles tri1 = new Triangles(10, 10, 10);
            while (true)
            {
                Console.WriteLine($"Váš trojuhelník ({ tri1.GetEquilateral}) rovnostraný se stranami A: {tri1.A}, B: {tri1.B}, C: {tri1.C} a s úhly alfa: {tri1.Alfa}°, beta: {tri1.Beta}°, gamma: {tri1.Gamma}°");
                Double? pick;
                Console.WriteLine
                (
                    "\nOperace s trojuhelníkem:\n" + 
                    "\t1. Změna strana\n" + 
                    "\t2. Změna násobku stran\n" + 
                    "\t3. Obvod\n" + 
                    "\t4. Obsah\n" +
                    "\t5. Konec\n"
                ); 
                pick = ReadDouble("Vyberte program: "); 
                switch (pick) 
                { 
                    case 1: 
                    {
                        tri1.Changer(ReadDouble("Zadejte novou stranu A: "), ReadDouble("Zadejte novou stranu B: "), ReadDouble("Zadejte novou stranu C: "));
                        break;
                    }
                    case 2: 
                    { 
                        tri1.Resizer(ReadDouble("Zadejte násobek stran: "));
                        break;
                    } 
                    case 3: 
                    { 
                        Console.WriteLine($"Obvod trojúhelníku: {tri1.GetPerimeter}");
                        break;
                    }
                    case 4:
                    { 
                        Console.WriteLine($"Obsah trojúhelníku: {tri1.GetArea}");
                        break;
                    } 
                    // Konec
                    case 5: 
                    { 
                        Console.WriteLine("Bye..."); 
                        Environment.Exit(0); 
                        return;
                    }
                    // Neco jineho nez 1 - 7
                    default: 
                    { 
                        Console.WriteLine("Neplatný input!"); 
                        break;
                    }
                }
            }
            
        }
    }
}