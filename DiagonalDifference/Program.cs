using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int count = 0; count < n; count++)
            {
            string s = Console.ReadLine();
            string[] stringArray = s.Split(new char[] { ' ' });
                for(int j = 0; j < n; j++)
                {
                    int i = count;
                    array[i, j] = Convert.ToInt32(stringArray[j]);
                }
            }
            
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        array[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            int MainDiag = 0 ;
            int SideDiag = 0 ;
            for (int i = 0; i < n; i++)
            {
                int j = i;
                MainDiag += array[i, j];
            }
            for (int i = 0; i<n; i++)
            {
                int j = n-i-1;
                SideDiag += array[i, j];
            }
            int result = Math.Abs(MainDiag - SideDiag);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
