using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        while(true)
        {
            Console.Clear();
            Console.WriteLine("𓋴𓃀𓈖𓏏𓍯𓄿 𓂋𓂧𓈖𓏌𓏲𓍯𓄿 𓋴𓍯𓄿𓂧𓈖𓏏");
            Console.WriteLine("The Sands of Time");
            Console.WriteLine("\n1. New Game");
            Console.WriteLine("2. Credits");
            Console.WriteLine("3. Exit");
            
            var input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    new Game().Start();
                    break;
                case "2":
                    ShowCredits();
                    break;
                case "3":
                    return;
            }
        }
    }

    static void ShowCredits()
    {
        Console.Clear();
        Console.WriteLine("Created by [Your Name]");
        Console.WriteLine("Inspired by Ancient Mesopotamian Culture");
        Console.WriteLine("\nPress any key to return...");
        Console.ReadKey();
    }
}