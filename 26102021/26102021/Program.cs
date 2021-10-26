using System;

namespace _26102021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 34, 56, 10, -13, 52 };

            int total = 0;
            int oddCount = 0;

            foreach (var item in numbers)
            {
                if (IsOdd(item) == true) oddCount++;
            }

            ShowTotal(oddCount);
            int result = Sum(45, 56);

            Console.WriteLine("salam");

            ShowHelloWorld();

            string nameOfStudent = "Hikmet";
            string surnameOfStudent = "Abdulla";

            Console.WriteLine($"fullname: {MakeFullName(nameOfStudent, surnameOfStudent)}");
            var num10 = 78;
            Console.WriteLine($"sum: {Sum(45,num10)}");

            bool hasOddInArr = HasOddNumInArr(numbers);

            Console.WriteLine($"hasOddInArr: {hasOddInArr}");
            ShowHasOddNumInArr(numbers);

            var resultOfSum = Sum(45, 5);
            Console.WriteLine($"result: {resultOfSum}");


            //var input = GetInput();
            Display("salam","fdf","fdsfs","fdsf","sag ol");

            string input = GetInput();
            string name = GetInput("Adinizi");
            string surname = GetInput("Soyadinizi");

            Console.WriteLine(MakeFullName(name,surname));

            #region HomeWork

            //task1
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8','9' };

            Console.WriteLine("Task1: Metni daxil edin:");
            string inputStr = Console.ReadLine();

            if (HasDigit(inputStr)) Console.WriteLine("Iceride reqem var");
            else Console.WriteLine("Iceride reqem yoxdur!");


            //task2
            Console.WriteLine("Task2: Metni daxil edin:");
            string inputStrOfTask2 = Console.ReadLine();

            for (int i = 0; i < inputStrOfTask2.Length-1; i++)
            {
                if(inputStrOfTask2[i]=='a' && inputStrOfTask2[i + 1] == 'l')
                {
                    Console.WriteLine("ardicil a ve l var");
                }
            }

            #endregion


        }

        static void ShowTotal(int total)
        {
            Console.WriteLine($"total={total}");
        }

        //static int Sum(int num1, int num2)
        //{
        //    var sum = num1 + num2;

        //    return sum;
        //}
        static int Sum(int a,int c, int b = 0)
        {
            var sum = a + b+c;

            return sum;
        }

        static int Sum(int a, int b,string resutlName)
        {
            var sum = a + b;

            return sum;
        }

        static void Display (params string[] strArr)
        {
            foreach (var str in strArr)
            {
                Console.WriteLine(str);
            }
        }
        
        static void ShowHelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        static bool IsOdd(int num)
        {
            bool result = num % 2 != 0;
            return result;
        }

        static string MakeFullName(string name,string surname)
        {
            var fullName = $"{name} {surname}";
            return fullName;
        }

        static bool HasOddNumInArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1) return true;
            }

            return false;
        }

        static void ShowHasOddNumInArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine("Siyahida tek eded var");
                    return;
                }
            }
            Console.WriteLine("Siyahda tek eded yoxdur");
        }

        static string GetName()
        {
            string text;
            do
            {
                Console.WriteLine("Adinizi daxil edin:");
                text = Console.ReadLine();

            } while (text.Length < 3 || text.Length > 20);

            return text;
        }

        static string GetSurname()
        {
            string text;
            do
            {
                Console.WriteLine("Soyadinizi daxil edin:");
                text = Console.ReadLine();

            } while (text.Length < 3 || text.Length > 20);

            return text;
        }

        static string GetInput(string inputName="Input")
        {
            string text;
            do
            {
                Console.WriteLine($"{inputName} daxil edin:");
                text = Console.ReadLine();

            } while (text.Length < 3 || text.Length > 20 || HasDigit(text));

            return text;
        }

        static bool IsExistCharInStr(string text,char chr)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == chr) return true;
            }

            return false;
        }

        static bool HasDigit(string text)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach (var digit in digits)
            {
                var isExist = IsExistCharInStr(text, digit);

                if (isExist)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
