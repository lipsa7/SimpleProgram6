using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdppractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(UserProgramCode.calculateDiff(arr));

            Console.ReadKey();
        }
    }

    class UserProgramCode
    {
        public static int calculateDiff(int[] arr)
        {
            int n = arr.Length;

            int max = 0;

            for(int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int min = 100;
            //assuming numbers in array are less than 100

            for(int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return (max - min);
        }
    }
}
