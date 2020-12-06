using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algo_Prac_1
{
    class Bubble_Sort_1
    {
        static void Main(string[] args)
        {
            bool swapped;
            int[] unsortedList = { 23, 21, 27, 25, 24, 22, 26, 28, 30, 29 };

            Console.Write("Unsorted List: ");
            for(int j = 0; j<unsortedList.Length; j++)
            {
                Console.Write("{0} ", unsortedList[j]);

            }

            do
            {
                swapped = false;
                
                for(int i = 0; i < unsortedList.Length-1; i++)
                {
                    if (unsortedList[i] > unsortedList[i + 1])
                    {
                        int temp = unsortedList[i];

                        unsortedList[i] = unsortedList[i + 1];

                        unsortedList[i + 1] = temp;

                        swapped = true;
                    }
                }

            } while (swapped == true);

            Console.WriteLine(" ");
            Console.Write("Sorted List: ");

            for(int k = 0; k < unsortedList.Length; k++)
            {
                Console.Write("{0} ", unsortedList[k]);
            }
            Console.ReadLine();
        }
    }
}
