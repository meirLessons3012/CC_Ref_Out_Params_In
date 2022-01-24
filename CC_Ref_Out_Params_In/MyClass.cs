using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Ref_Out_Params_In
{
    internal class MyClass
    {
        public int age;
        public int age1;
        public int age2;
        public int age3;

        public MyClass(int age = 0, int age1 = 0, int age2 = 0, int age3 = 0)
        {
            this.age = age;
            this.age1 = age1;
            this.age2 = age2;
            this.age3 = age3;
        }

        //public MyClass()
        //{

        //}

        //public MyClass(int age)
        //{
        //    this.age = age;
        //}

        //public MyClass(int age, int age1) : this(age)
        //{
        //    this.age1 = age1;
        //}

        //public MyClass(int age, int age1, int age2) : this(age, age1)
        //{
        //    this.age2 = age2;
        //}

        //public MyClass(int age, int age1, int age2, int age3) : this(age, age1, age2)
        //{
        //    this.age3 = age3;
        //}
    }
}
