using System;

namespace PROG0001
{
    class Program
    {
        static void Main()
        {
            int var1 = 5;
            Console.WriteLine("Hello World!");
            Console.WriteLine("The value of var1 is {0}", var1);
            Console.Write("This is a trival text.\n");
            Console.WriteLine("This is text1.");
            Console.WriteLine("This is text2.");
            Console.WriteLine("This is text3.");
            Console.WriteLine("Two sample integers are {0} and {1}.", 3, 6);
            Console.WriteLine("Three integers are {1},{0} and {1}.", 3, 6);
            Console.WriteLine("The value: {0:C}.", 500);
            Console.WriteLine("{0,10}", 500);
            Console.WriteLine("|{0,10}|", var1);
            Console.WriteLine("|{0,-10}|", var1);
            double mydouble = 12.345678;
            Console.WriteLine("{0,-10:G}--General", mydouble);
            Console.WriteLine("{0,-10}--Default, same as General", mydouble);
            Console.WriteLine("{0,-10:F4}--Fixed Point, 4 dec places", mydouble);
            Console.WriteLine("{0,-10:C}--Currency", mydouble);
            Console.WriteLine("{0,-10:E3}--Sci.Notation, 3 dec places", mydouble);
            Console.WriteLine("{0,-10:e3}--Sci.Notation, 3 dec places", mydouble);
            Console.WriteLine("{0,-10:x}--Hexadecimal integer", 1191235);
            Console.WriteLine("{0,-10:X}--Hexadecimal integer", 1191235);
            Console.WriteLine("{0:c}", 12.5);
            Console.WriteLine("{0:d4}", 12);
            Console.WriteLine("{0:n2}", 12.4123);
            Console.WriteLine("{0:p2}", 0.1234);
            // 从程序中输出文本
            /*
             * 为代码添加注释
             */
        }
    }
}
