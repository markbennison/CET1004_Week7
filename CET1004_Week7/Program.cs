using System.IO;

namespace CET1004_Week7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many notes would you like?");
            int numberOfNotes = Convert.ToInt32(Console.ReadLine());

            string[] notes = new string[numberOfNotes];

            for (int i = 0; i < numberOfNotes; i++)
            {
                Console.WriteLine("Enter note " + (i + 1) + ":");
                notes[i] = Console.ReadLine();

            }

            Console.WriteLine("Enter a filename");
            string filename = Console.ReadLine() + ".txt";

            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                for (int i = 0; i < notes.Length; i++)
                {
                    sw.WriteLine(notes[i]);
                }
            }


        }


        static void ObjectListExample()
        {
            Console.WriteLine("How many products?");
            int numberOfProducts = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"Enter the name of product {i + 1}:");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter the quantity of product {i + 1}:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Product.AddProductToList(name, quantity);
            }

            Console.WriteLine("\n\n");

            Product.DisplayProducts();
            Console.WriteLine("\n\n Total quantity: " + Product.CumulativeQty());

            Console.ReadKey();
        }

        static void ArrayExample()
        {
            Console.WriteLine("How many products?");
            int numberOfProducts = Convert.ToInt32(Console.ReadLine());

            string[] productNames = new string[numberOfProducts];
            int[] productQty = new int[numberOfProducts];
            int cumulativeQty = 0;

            for (int i = 0; i < productNames.Length; i++)
            {
                Console.WriteLine($"Enter the name of product {i + 1}:");
                productNames[i] = Console.ReadLine();
                Console.WriteLine($"Enter the quantity of product {i + 1}:");
                productQty[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < productNames.Length; i++)
            {
                Console.WriteLine("Product: " + productNames[i] + ", Quantity: " + productQty[i]);
                cumulativeQty += productQty[i];
            }

            Console.WriteLine("Total quantity: " + cumulativeQty);

        }
    }

}
