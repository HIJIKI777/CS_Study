using System;

namespace person{
    class person_data{

        //こういうstringとかintとかのパーツは フィールド という
        public string name = "";
        public int age = 0;
        public int age2 = 0;
        public int age3 = 0;

        //こういうvoidとかの関数は メソッド という
        public void Show(){
            Console.WriteLine("{0},{1}",name,age);
        }
        public void Set(string name, int age){
            this.name = name;
            this.age = age;
        }

        //同じ名前だけど引数異なる，これがオーバロード
        public void add(int age, int age2){
            age = age + age2;
            Console.WriteLine(age);
        }
        public void add(int age,int age2,int age3){
            age = age + age2 + age3;
            Console.WriteLine(age);
        }
    }
}