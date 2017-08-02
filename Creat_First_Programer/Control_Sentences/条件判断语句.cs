using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Sentences
{
    class Jude
    {
        public static void condition_Judge()
        {
            string input_string;
            int numtrasform_input_string;

            Console.WriteLine("please in put 1 ,2 or 3");
            input_string = Console.ReadLine();
            numtrasform_input_string = int.Parse(input_string);

            if (numtrasform_input_string == 1)
            {
                Console.WriteLine("What you are input is " + 1);
            }
            else if (numtrasform_input_string == 2)
            {
                Console.WriteLine("What you are input is " + 2);

            }
            else
            {
                Console.WriteLine("What you are input is others");
            }

            Console.WriteLine("What you are input is " + (numtrasform_input_string == 1 ? 1 : (numtrasform_input_string == 2 ? 2 : 3)));

        }
        public static void loop()
        {
            Console.WriteLine("this is  the example of while :");
            int i = 0;
            while (i < 10)
            {
                if(i<5)
                    Console.WriteLine("the num is lower than 5");
                else
                    Console.WriteLine("the num is no lower than 5");
                i++;
            }
            Console.WriteLine("this is  the example of do-while :");
            i = 0;
            do
            {
                if (i < 5)
                    Console.WriteLine("the num is lower than 5");
                else
                    Console.WriteLine("the num is no lower than 5");
                i++;
            } while (i < 10);
            Console.WriteLine("this is  the example of for :");
            for (int si = 0; si < 10; si++)
            {
                if (si < 5)
                    Console.WriteLine("the num is lower than 5");
                else
                    Console.WriteLine("the num is no lower than 5");
            }


        }
    }
}
