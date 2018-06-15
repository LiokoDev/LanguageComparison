namespace FileRead
{
    using System;
    using System.IO;

    /// <summary>
    /// File reader demonstration program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Application Entry point
        /// </summary>
        /// <param name="args">Program arguments (unused)</param>
        static void Main(string[] args)
        {
            try
            {
                // Read all of the lines of the test file into a list. 
                var lines = File.ReadAllLines("testfile.txt");

                // Loop over the lines, printing them to the console.
                foreach (var line in lines)
                {
                    Console.WriteLine("Read Line: {0}", line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading testfile");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
