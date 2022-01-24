using System;

namespace CC_Ref_Out_Params_In
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine($"x Before Method: {x}");
            int y = x;

            MyClass mc = new MyClass();
            mc.age = 10;
            Console.WriteLine($"mc Before Method: {mc.age}");

            //int xForMethod = x;
            //object xForMethod = x;
            Foo(ref x);
            Console.WriteLine($"x After Method: {x}");

            //MyClass mcForMethod = mc;
            FooForMyClass(mc);
            Console.WriteLine($"mc After Method: {mc.age}");

            string errorMessage = "", token;
            if (!IsLoginSuccess("momi", "123", ref errorMessage, out token))
                Console.WriteLine(errorMessage);


            //Out
            int x13;
            MethodWithOut(out x13);
            Console.WriteLine(x13);

            int myNumber;
            int.TryParse("13", out myNumber);// true = myNumber = 13 (int)
            int.TryParse("1321fca", out myNumber);// false = myNumber = 0 (int)
            Console.WriteLine(myNumber);

            //Params
            double[] doublesArray = { 13.2, 14, 5, 15, 10, 2 };
            CalcNumberWithParams(doublesArray);
            CalcNumberWithParams(13.2, 14, 5, 15, 10, 2);

            //In
            KeepMyValue(13);
            KeepMyValueWithRefType(mc);

            //Params
            ShowMessage("hello hackeru");//withOkButton = true
            ShowMessage("hello hackeru", false);//withOkButton = false

            //Optional Arguments
            MyClass mc3 = new MyClass();
            MyClass mc4 = new MyClass(13);
            MyClass mc5 = new MyClass(13, 15);
            MyClass mc6 = new MyClass(13, 15, 11);
            MyClass mc7 = new MyClass(13, 15, 11, 10);

            //Named Arguments
            MyClass mc8 = new MyClass(age1: 13, age3: 22, age2: 10);
            bool isPrinted = false;
            GetPersonDetails("Shuli", 34, "Male", 1.81f, ref isPrinted);
            GetPersonDetails(printedBefore: ref isPrinted, name: "Shuli", age: 34, gender: "Male", high: 1.81f);




            //Exr Ref Out

            //1
            int howManyRecycled = 0, maxRecycled = 5;
            string[] type = { "plastik", "Matehet", "Naylon", "zhuhit" };
            Bottle[] bottles = new Bottle[1000];
            Random random = new Random();
            for (int i = 0; i < bottles.Length; i++)
            {
                bottles[i] = new Bottle(type[random.Next(0, 4)]);
            }
            for (int i = 0; i < bottles.Length; i++)
            {
                bottles[i].Recycle(ref howManyRecycled, maxRecycled);
                if (howManyRecycled >= maxRecycled)
                    break;
            }

            //2
            int myInt;
            MethodWithOut1(out myInt);
            MethodWithRef(ref myInt);
        }

        #region Ref And Out
        public static void Foo(ref int x)
        {
            x++;
            x++;
            x++;
            x++;
            Console.WriteLine($"x In Method: {x}");
        }

        public static void FooForMyClass(MyClass mc)
        {
            mc.age++;
        }

        public static void MethodWithOut(out int myX)
        {
            //myX++;Error
            myX = 10;
            myX++;
            myX--;
        }

        public static bool IsLoginSuccess(string userName, string password, ref string message, out string token)
        {
            if (userName == "momo" && password == "123")
            {
                token = "wejfcqo23ircuoqwdmlqk2u3oiqcjlkdjaclsd";
                return true;
            }
            else
            {
                token = null;
                message = "username or password incorrect";
                return false;
            }
        }

        #endregion

        #region params

        public static double CalcNumbers(double n1, double n2)
        {
            double result = 0;
            result += n1;
            result += n2;
            return result;
        }

        public static double CalcNumbers(double n1, double n2, double n3)
        {
            double result = 0;
            result += n1;
            result += n2;
            return result;
        }

        public static double CalcNumberWithParams(params double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }

        #endregion

        //in
        public static void KeepMyValue(in int supVal)
        {
            //supVal = 3; //It’s Not Possible // Error In Compile Time
        }

        public static void KeepMyValueWithRefType(in MyClass myClass)
        {
            //myClass = null;
            //myClass = new MyClass();
            myClass.age = 15;
        }

        //Optional Arguments
        public static void ShowMessage(string message, bool withOkButton = true)
        {
            Console.WriteLine(message);
            if (withOkButton)
                Console.WriteLine("OK");
        }

        //Named Arguments
        public static void GetPersonDetails(in string name, int age, string gender, float high, ref bool printedBefore)
        {
            Console.WriteLine("Name: {0}, Age: {1}, Gender: {2}, High: {3}", name, age, gender, high);
        }

        //Exr Out And Ref
        public static  void MethodWithRef(ref int myRefInt)
        {
            myRefInt = 13;
        }
        public static void MethodWithOut1(out int myOutInt)
        {
            myOutInt = 2;
        }
    }
}
