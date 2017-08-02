using System;

namespace _4_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Fnc_Array();
            Console.ReadLine();

        }
        public static void Fnc_Array()
        {
            //一维数组
            int[] Array_num = new int[10];
            Console.WriteLine("Print  out the num of the array:");
            for (int si = 0; si < Array_num.Length; si++)
            {
                Array_num[si] = si + 1;
                Console.WriteLine(si.ToString());
            }
            Console.WriteLine("Print  out the usage of foreach:");
            foreach (var sichar in Array_num)
            {
                Console.WriteLine(sichar.ToString());
            }
            //多位数组
            Console.WriteLine("this is the test if multi_array :");
            int[,] Multi_Array_num = new int[3, 4];
            for (int si = 0; si < 3; si++)
            {
                for (int sj = 0; sj < 4; sj++)
                {
                    Multi_Array_num[si, sj] = si + sj;
                }
            }
            foreach (var snum in Multi_Array_num)
            {

                Console.WriteLine(snum);

            }

            //jagged array
            int[][] Jagged_array_num = new int[4][];
            Jagged_array_num[0] = new int[1] { 1 };
            Jagged_array_num[1] = new int[2] { 1, 2 };
            Jagged_array_num[2] = new int[3] { 1, 2, 3 };
            Jagged_array_num[3] = new int[4] { 1, 2, 3, 4 };

            Console.WriteLine("this is the example of jagged array:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Jagged_array_num[i][j] = i + j;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.WriteLine(Jagged_array_num[i][j]);
                }
            }

        }
    }
}