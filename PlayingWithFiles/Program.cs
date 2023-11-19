using System;
using FileHandlingBasic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.IO;

namespace PlayingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                WriteHeadingToScreen();
                Console.WriteLine("Please enter the name of the file");
                string fileName = Console.ReadLine();
                string[] lines = new string[3];
                TextFileFunctions textFileFunctions = new TextFileFunctions(fileName+".txt");
                int counter = 0;

                do
                {
                    Console.WriteLine($"Please add {(counter == 0 ? "a line" : "another line")} to the file:{fileName}.txt");
                    lines[counter] = Console.ReadLine();
                    counter++;
                } while (counter<3);

                textFileFunctions.WriteTextToFile(lines);
                Console.Clear();
                WriteHeadingToScreen();
                Console.Write(textFileFunctions.ReadFile());
                Console.Read();
            }
            catch (IOException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
        
        private static void WriteHeadingToScreen()
        {
            Console.WriteLine("Basic .NET Cross Platform File Handling");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
        }
    }
}
