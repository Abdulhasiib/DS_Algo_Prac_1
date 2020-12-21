using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algo_Prac_1
{
    class InsertionSort
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Enter Numbers of unsorted Array");
            string before = Console.ReadLine();
            char[] unsort = before.ToCharArray();

            int[] unsortArr = Array.ConvertAll(unsort, c => (int)char.GetNumericValue(c));

            for(int i=1; i<unsortArr.Length; i++)
            {
                int newnumber = unsortArr[i];

                int j = i;

                while (j > 0 && unsortArr[j-1] > newnumber)
                {
                    unsortArr[j] = unsortArr[j-1];

                    j--;
                }

                unsortArr[j] = newnumber;
                
            }

            string after = "";
            for(int i=0; i < unsortArr.Length; i++)
            {
                after = after + unsortArr[i];
            }

            
            Console.WriteLine("Unsorted Array: {0}", before);
            Console.WriteLine("Sorted Array: {0}", after);

            Console.ReadLine();
        }
    }
}
