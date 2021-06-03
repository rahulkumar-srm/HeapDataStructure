using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapDataStructure.Helper
{
    internal class MaxHeap
    {
        private int top = 0;
        private int[] Items { get; set; }

        public MaxHeap(int size)
        {
            Items = new int[size];
        }

        internal void CreateHeap()
        {
            while (true)
            {
                Console.WriteLine("Enter the number");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == -1)
                {
                    break;
                }

                InsertNode(num);
            }

            DisplayHeap();
        }

        internal void InsertNode(int num)
        {
            if(top >= Items.Length - 1)
            {
                Console.WriteLine("No space available");
                return;
            }

            int i = ++top;

            while(i > 1 && Items[i / 2] < num)
            {
                Items[i] = Items[i / 2];
                i = i / 2;
            }

            Items[i] = num;
        }

        internal void DisplayHeap()
        {
            for(int i = 1; i <= top; i++)
            {
                Console.Write(Items[i] + " ");
            }

            Console.WriteLine();
        }

        internal void DeleteNode()
        {
            Items[1] = Items[top];
            Items[top--] = 0;

            int i = 1, j = i * 2;

            while (j <= top)
            {
                if (j < top && Items[j + 1] > Items[j])
                {
                    j = j + 1;
                }

                if(Items[j] > Items[i])
                {
                    int temp = Items[i];
                    Items[i] = Items[j];
                    Items[j] = temp;

                    i = j;
                    j = 2 * j;
                }
                else
                {
                    break;
                }
            }

            DisplayHeap();
        }

        internal void HeapifyCreate(int[] items, int top)
        {
            for(int i = top / 2; i > 0; i--)
            {
                int j = i;
                int K = i * 2;

                while (K <= top)
                {
                    if (K < top && items[K + 1] > items[K])
                    {
                        K = K + 1;
                    }

                    if (K <= top && items[K] > items[j])
                    {
                        int temp = items[j];
                        items[j] = items[K];
                        items[K] = temp;

                        j = K;
                        K = j * 2;
                    }
                    else
                        break;
                }
            }

            Items = items;
            this.top = top;

            DisplayHeap();
        }
    }
}
