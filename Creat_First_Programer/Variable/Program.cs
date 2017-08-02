using System;


namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            //变量声明与赋值
            int x, y;
            x = 1;
            y = 1;
            Console.WriteLine("Sum of x and y is "+ (x + y));

            string myfirstname = "wubing";
            string mysecondname = "chen";
            Console.WriteLine("My name is " + myfirstname + " " + mysecondname);

            //类型转换
            Console.WriteLine("Integer followed by string " + (x.ToString() + myfirstname));

            Console.WriteLine("String followed by integer " + (x + int.Parse("22")));

            Console.Read();

        }
    }
}