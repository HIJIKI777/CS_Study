using System;

namespace arr{
    class Program{
        static void Main(string[] args){
            double[] d = new double[5];     //newで生成
            d[0] = 1.2;
            d[1] = 3.7;
            d[2] = 4.1;
            double sum,avg;
            sum = 0.0;
            foreach (int i in d)    //forの配列，リスト版（？）．int i in (対象の配列・リスト名)でやる
            {
                sum += d[i];
            }

            avg = sum / 3;
            Console.WriteLine(sum);
            Console.WriteLine(avg);

            int[,] twodim = new int[5,5];           //C#の二次元配列は[i][m]ではなく[i,m]
            for(int i = 0; i < 3; i++){             //また，[i][m]の形はジャグ配列で使われる
                for(int j = 0; j < 3; j++){
                    twodim[i,j] = i + j;
                }
            }

            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    Console.Write(twodim[i,j]);
                }
            }
            Console.Write("\n");
        }
    }

}