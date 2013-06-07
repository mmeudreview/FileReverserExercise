using System;

namespace ReverserConsole
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 0) return;
                Console.WriteLine("Please enter the location (full path) and filename of file to reverse");
                var inputFile = Console.ReadLine();

                if (args.Length != 0) return;
                Console.WriteLine("Please enter the location (full path) and filename of the desired ouput file to output reversed text");
                var outputFile = Console.ReadLine();

                /* enter code that meets the acceptance criteria here */
                var reversed = string.Empty;

                if (string.IsNullOrEmpty(reversed))
                    Console.WriteLine("File not created.  Exiting ...");
                else
                {
                    Console.WriteLine("the input file: " + inputFile);
                    Console.WriteLine("has been reversed and output to the file: " + outputFile);
                    Console.WriteLine("with the reversed content: " + reversed);

                    if (args.Length != 0) return;
                    var exitText = Console.ReadLine();
                    Console.WriteLine("Please press any key to exit " + exitText);
                }
            }
            catch (Exception e)
            {
                Console.Write("{0} Exception Caught:", e.Message);
            }
        }
    }
}
