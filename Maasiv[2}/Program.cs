using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maasiv_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int m = int.Parse(num[1]);


            string[,] str = new string[n, m];
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    str[i, j] = s[j];
                    arr[i, j] = int.Parse(s[j]);
                }

            }
            Console.ReadLine();

            string[,] str1 = new string[n, m];
            int[,] arr1 = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] s1 = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    str1[i, j] = s1[j];
                    arr1[i, j] = int.Parse(s1[j]);

                }

            }



            int[,] arrres = new int[n, m];
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {

                    arrres[i, j] = arr[i, j] + arr1[i, j];
                }

            }



            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    Console.Write(arrres[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Console.ReadKey();

        }
    }
}
