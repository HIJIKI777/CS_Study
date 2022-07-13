using System;

namespace string_pra{
    class Prigram{
        static void Main(string[] args){
            string str1,str2;
            Console.Write("str1 = ");           //WriteLineとは違い，改行無し
            str1 = Console.ReadLine();
            Console.Write("str2 = ");           //WriteLineとは違い，改行無し
            str2 = Console.ReadLine();
            string str3;
            str3 = str1 + str2;
            Console.WriteLine("{0} + {1} = {2}",str1,str2,str3);
            //const ~~~ をつけた変数は値を変更できない．円周率など，書き換えられちゃいけない値に用いるのが良き
        }
    }
}