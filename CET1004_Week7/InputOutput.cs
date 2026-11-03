using System;
using System.Collections.Generic;
using System.Text;

namespace CET1004_Week7
{
    internal class InputOutput
    {

        public static void WriteToFile(string filename, string[] notes)
        {
            Console.WriteLine("\n\nWriting to File...");
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                for (int i = 0; i < notes.Length; i++)
                {
                    sw.WriteLine(notes[i]);
                    Console.WriteLine(notes[i]);
                }
            }
            Console.WriteLine("\n\nWriting to File...");
        }

        public static void WriteToFile(string filename, List<string> notes)
        {
            Console.WriteLine("\n\nWriting to File...");
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                for (int i = 0; i < notes.Count; i++)
                {
                    sw.WriteLine(notes[i]);
                    Console.WriteLine(notes[i]);
                }
            }
            Console.WriteLine("\n\nWriting to File...");
        }

    }
}
