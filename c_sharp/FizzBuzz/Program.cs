using System;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int start;
            int end;
            int fizzNumber;
            int buzzNumber;
            string fizz;
            string buzz;
            int argsCount = 6;

            // args の中身をチェックして、何もなかったらデフォルトの値を代入
            if (args.Length != argsCount)
            {
                start = 0;
                end = 100;
                fizzNumber = 3;
                buzzNumber = 5;
                fizz = "Fizz";
                buzz = "Buzz";
                Console.WriteLine($"初期の引数が足りていません。{argsCount}つ入れてください。");
            }
            else
            {
                start = int.Parse(args[0]); // FizzBuzzの開始数字
                end = int.Parse(args[1]); // FizzBuzzの終了数字
                fizzNumber = int.Parse(args[2]); // Fizzの条件
                buzzNumber = int.Parse(args[3]); // Buzzの条件
                fizz = args[4];
                buzz = args[5];
            }

            for (var i = start; i <= end; i++)
            {
                Console.WriteLine(FizzBuzz(i, fizzNumber, buzzNumber, fizz, buzz));
            }
        }

        public static string FizzBuzz(int num, int fizzNumber, int buzzNumber, string fizz, string buzz)
        {
            string? s = null;

            if (num % fizzNumber == 0)
            {
                s = fizz;
            }

            if (num % buzzNumber == 0)
            {
                s += buzz;
            }
            return s ?? num.ToString();
        }
    }
}