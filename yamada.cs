using System;
using person;

namespace yamada{
    class yamada_data{
        static void Main(string[] args){
            person_data p1,p2;
            p1 = new person_data();     //newでインスタンス生成
            p2 = new person_data();     //newでインスタンス生成
            p1.Set("山田太郎",16);
            p2.Set("山田花子",15);
            p1.Show();
            p2.Show();
            p1.add(14,15);              //これがオーバーロード
            p1.add(14,15,16);
        }
    }
}