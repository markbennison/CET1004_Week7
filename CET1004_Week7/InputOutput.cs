using System;
using System.Collections.Generic;
using System.Text;

namespace CET1004_Week7
{
    internal class InputOutput
    {
        // Writing to File with known filename using ARRAY
        public static void WriteToFile(string filename, string[] notes, bool append = false)
        {
            Console.WriteLine("\n\nWriting to File...");
            using (StreamWriter sw = new StreamWriter(filename, append))
            {
                for (int i = 0; i < notes.Length; i++)
                {
                    sw.WriteLine(notes[i]);
                    Console.WriteLine(notes[i]);
                }
            }
            Console.WriteLine("\n\nWriting to File...");
        }

        // Writing to File with known filename using LIST
        public static void WriteToFile(string filename, List<string> notes, bool append = false)
        {
            Console.WriteLine("\n\nWriting to File...");
            using (StreamWriter sw = new StreamWriter(filename, append))
            {
                for (int i = 0; i < notes.Count; i++)
                {
                    sw.WriteLine(notes[i]);
                    Console.WriteLine(notes[i]);
                }
            }
            Console.WriteLine("\n\nWriting to File...");
        }

        // Writing to File with unknown filename using array
        public static void WriteToFile(string[] notes, bool append = false)
        {
            Console.Clear();

            Console.WriteLine("Enter a filename");
            string filename = Console.ReadLine() + ".txt";

            Console.WriteLine("\n\nWriting to File...");
            using (StreamWriter sw = new StreamWriter(filename, append))
            {
                for (int i = 0; i < notes.Length; i++)
                {
                    sw.WriteLine(notes[i]);
                    Console.WriteLine(notes[i]);
                }
            }
            Console.WriteLine("\n\nWriting to File...");
        }

        // Writing to File with unknown filename using LIST
        public static void WriteToFile(List<string> notes, bool append = false)
        {
            Console.Clear();

            Console.WriteLine("Enter a filename");
            string filename = Console.ReadLine() + ".txt";

            Console.WriteLine("\n\nWriting to File...");
            using (StreamWriter sw = new StreamWriter(filename, append))
            {
                for (int i = 0; i < notes.Count; i++)
                {
                    sw.WriteLine(notes[i]);
                    Console.WriteLine(notes[i]);
                }
            }
            Console.WriteLine("\n\nWriting to File...");
        }

        // Writing to File with unknown filename using ARRAY - ask to append or overwrite
        public static void WriteToFile(string[] notes)
        {
            bool append = true;
            Console.Clear();

            Console.WriteLine("Enter a filename");
            string filename = Console.ReadLine() + ".txt";

            Console.WriteLine("Would you like to overwrite the file? (y/n)");
            string overwrite = Console.ReadLine();
            if (overwrite.ToLower() == "y")
            {
                append = false;
            }

            Console.WriteLine("\n\nWriting to File...");
            using (StreamWriter sw = new StreamWriter(filename, append))
            {
                for (int i = 0; i < notes.Length; i++)
                {
                    sw.WriteLine(notes[i]);
                    Console.WriteLine(notes[i]);
                }
            }
            Console.WriteLine("\n\nWriting to File...");
        }

        // Writing to File with unknown filename using LIST - ask to append or overwrite
        public static void WriteToFile(List<string> notes)
        {
            bool append = true;
            Console.Clear();

            Console.WriteLine("Enter a filename");
            string filename = Console.ReadLine() + ".txt";

            Console.WriteLine("Would you like to overwrite the file? (y/n)");
            string overwrite = Console.ReadLine();
            if (overwrite.ToLower() == "y")
            {
                append = false;
            }

            Console.WriteLine("\n\nWriting to File...");
            using (StreamWriter sw = new StreamWriter(filename, append))
            {
                for (int i = 0; i < notes.Count; i++)
                {
                    sw.WriteLine(notes[i]);
                    Console.WriteLine(notes[i]);
                }
            }
            Console.WriteLine("\n\nWriting to File...");
        }

        public static string ReadFromFile(string filename)
        {
            Console.WriteLine("\n\nReading from File...");
            string fileContents = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                int lineNumber = 1;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    fileContents += lineNumber.ToString().PadLeft(5) + ": " + line + "\n";
                    lineNumber++;
                }
            }
            Console.WriteLine(fileContents);
            Console.WriteLine("\n\nReading from File...");
            return fileContents;
        }

        public static string ReadFromFile()
        {
            Console.Clear();

            Console.WriteLine("Enter a filename");
            string filename = Console.ReadLine() + ".txt";

            Console.WriteLine("\n\nReading from File...");
            string fileContents = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                int lineNumber = 1;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    fileContents += lineNumber.ToString().PadLeft(3) + ": " + line + "\n";
                    lineNumber++;
                }
            }
            Console.WriteLine(fileContents);
            Console.WriteLine("\n\nReading from File...");
            return fileContents;
        }

    }

}
