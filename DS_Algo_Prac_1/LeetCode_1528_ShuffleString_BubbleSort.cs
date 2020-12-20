using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algo_Prac_1
{
    class LeetCode_1528_ShuffleString_BubbleSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();

            char[] sa = s.ToCharArray();

            Console.WriteLine("Enter Indices:");
            
            char[] index = Console.ReadLine().ToCharArray();

            int[] intarr = Array.ConvertAll(index, c => (int)Char.GetNumericValue(c));

            bool swapped;
            do
            {
                swapped = false;

                for (int i = 0; i < intarr.Length-1; i++)
                {
                    if (intarr[i] > intarr[i + 1])
                    {
                        int temp = intarr[i + 1];
                        char temp2 = sa[i + 1];

                        intarr[i + 1] = intarr[i];
                        sa[i + 1] = sa[i];

                        intarr[i] = temp;
                        sa[i] = temp2;

                        swapped = true;
                    }
                }
            } while (swapped == true);

            string snew = "";
            for(int i=0; i<sa.Length; i++)
            {
                snew = snew + sa[i];
            }

            Console.WriteLine("String before: {0}", s);
            Console.WriteLine("String after: {0}", snew);

            Console.ReadLine();
        }
    }
}
