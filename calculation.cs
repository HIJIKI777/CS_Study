using System;

namespace calculation
{
    class Program{
        static void Main(string[] args){
            int a = 5;
            int b = 670;
            Console.WriteLine(a * b);
            Console.WriteLine(a + b);
            Console.WriteLine(b / a);
            Console.WriteLine(b % a);
            Console.WriteLine("{0} + {1} = {2}",a,b,a+b);   //printfみたいなもん
        }
    }
}