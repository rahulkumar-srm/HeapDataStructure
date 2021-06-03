using HeapDataStructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxHeap maxHeap = new MaxHeap(10);

            while (true)
            {
                Console.WriteLine
                    ("Please select an option" +
                        Environment.NewLine + "1. Create Heap" +
                        Environment.NewLine + "2. Insert Node" +
                        Environment.NewLine + "3. Delete Node" +
                        Environment.NewLine + "4. Create Heap - Heapify Method" +
                        Environment.NewLine + "0. Exit"
                    );

                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine(Environment.NewLine + "Input format is not valid. Please try again." + Environment.NewLine);
                }

                if (i == 0)
                {
                    Environment.Exit(0);
                }
                else if (i == 1)
                {
                    maxHeap.CreateHeap();

                }
                else if (i == 2)
                {
                    //tree.InsertNode();
                }
                else if (i == 3)
                {
                    maxHeap.DeleteNode();
                }
                else if (i == 4)
                {
                    Console.WriteLine("Enter the numbers{comma separated)"); //30,15,35,40,10,12,6,5,20
                    int[] items = ("0, " + Console.ReadLine()).Split(',').Select(x => Convert.ToInt32(x.Trim())).ToArray();

                    maxHeap.HeapifyCreate(items, items.Length - 1);
                }
                else
                {
                    Console.WriteLine("Please select a valid option.");
                }
            }
        }
    }
}
