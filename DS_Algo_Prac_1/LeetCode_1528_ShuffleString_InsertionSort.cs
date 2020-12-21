using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algo_Prac_1
{
    class LeetCode_1528_ShuffleString_InsertionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string inputstr = Console.ReadLine();
            char[] strChar = inputstr.ToCharArray();
            
            Console.WriteLine("Enter indices:");
            string inputindex = Console.ReadLine();

            char[] charindex = inputindex.ToCharArray();

            int[] indices = Array.ConvertAll(charindex, c => (int)Char.GetNumericValue(c));

            for(int i=1; i < indices.Length; i++)
            {
                int NewValue = indices[i];
                char NewChar = strChar[i];
                int j = i;

                while(j>0 && indices[j - 1] > NewValue)
                {
                    indices[j] = indices[j - 1];
                    strChar[j] = strChar[j - 1];

                    j--;
                }

                indices[j] = NewValue;
                strChar[j] = NewChar;
            }

            string newString = "";
            for(int i=0; i < strChar.Length; i++)
            {
                newString = newString + strChar[i];
            }

            Console.WriteLine("Shuffled String: {0}", newString);
            Console.ReadLine();
        }
    }
}
