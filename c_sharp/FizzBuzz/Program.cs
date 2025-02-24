using System;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz");
            Console.WriteLine("任意の倍数の時に、任意のテキストに置き換えることができるプログラムです。");
            Console.WriteLine("また、この処理を3つ設定でき、それぞれの約数の時に両方のテキストを足して表示します。");

            Console.WriteLine("startの値を入力してください");
            string? startText = getValidReadLine(); // 入力受付
            int start = setInt(startText, 0);

            Console.WriteLine("endの値を入力してください");
            string? endText = getEndValidReadLine(start); // 入力受付
            int end = setInt(endText, 0);

            Console.WriteLine("最初の倍数を入力してください");
            string? fizzText = getFizzNumberValidReadLine(end); // 入力受付
            int fizzNumber = setInt(fizzText, 3);

            Console.WriteLine("2つ目の倍数を入力してください");
            string? buzzText = getBuzzNumberValidReadLine(end, fizzNumber); // 入力受付
            int buzzNumber = setInt(buzzText, 5);

            Console.WriteLine("3つ目の倍数を入力してください");
            string? triText = getTriNumberValidReadLine(end, fizzNumber, buzzNumber); // 入力受付

            Console.WriteLine("最初の倍数を置き換えるテキストを入力してください");
            string? fizzWord = getFizzTextValidReadLine(); // 入力受付

            Console.WriteLine("2つ目の倍数を置き換えるテキストを入力してください");
            string? buzzWord = Console.ReadLine(); // 入力受付

            Console.WriteLine("3つ目の倍数を置き換えるテキストを入力してください");
            string? triWord = Console.ReadLine(); // 入力受付


            int triNumber = setInt(triText, 7);
            string fizz = setText(fizzWord, "fizz");
            string buzz = setText(buzzWord, "buzz");
            string tri = setText(triWord, "tri");

            for (var i = start; i <= end; i++)
            {
                Console.WriteLine(FizzBuzz(i, fizzNumber, buzzNumber, triNumber, fizz, buzz, tri));
            }
        }

        private static string? getValidReadLine()
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int num) && num > 0)
                {
                    return input;
                }
                Console.WriteLine("数値を入力してください。");
            }
        }

        private static string? getEndValidReadLine(int start)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int num) && num > 0 && num > start)
                {
                    return input;
                }
                Console.WriteLine("startの値よりも小さい数値が入力されている、または数値が入力されていません。再度入力してください。");
            }
        }

        private static string? getFizzNumberValidReadLine(int end)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int num) && num > 0 && num < end)
                {
                    return input;
                }
                Console.WriteLine("endの値よりも大きい数値が入力されている、または数値が入力されていません。再度入力してください。");
            }
        }

        private static string? getBuzzNumberValidReadLine(int end, int fizzNumber)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int num) && num > 0 && num < end && fizzNumber != num)
                {
                    return input;
                }
                Console.WriteLine("endの値よりも大きい数値が入力されている、または最初の倍数と同じ値になっている、または数値が入力されていません。再度入力してください。");
            }
        }

        private static string? getTriNumberValidReadLine(int end, int fizzNumber, int buzzNumber)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int num) && num > 0 && num < end && fizzNumber != num && buzzNumber != num)
                {
                    return input;
                }
                Console.WriteLine("endの値よりも大きい数値が入力されている、または既に入力した倍数と同じ値になっている、または数値が入力されていません。再度入力してください。");
            }
        }

        private static string? getFizzTextValidReadLine()
        {
            while (true)
            {
                string? input = Console.ReadLine();
                Console.WriteLine("int.TryParse(input, out int num)の結果：" + int.TryParse(input, out int numTest));
                Console.WriteLine("num == 0の結果: " + numTest);
                Console.WriteLine("inputの結果：" + input);

                if (int.TryParse(input, out int num) && num == 0 && input != null)
                {
                    return input;
                }
                Console.WriteLine("文字列が入力されていません。再度入力してください。");
            }
        }

        private static int setInt(string? parseValue, int defaultValue)
        {
            if (parseValue != null)
            {
                return int.Parse(parseValue); // FizzBuzzの開始数字
            }
            else
            {
                return defaultValue;
            }
        }

        private static string setText(string? parseValue, string defaultValue)
        {
            if (parseValue != null)
            {
                return parseValue; // FizzBuzzの開始数字
            }
            else
            {
                return defaultValue;
            }
        }

        public static string FizzBuzz(int num, int fizzNumber, int buzzNumber, int triNumber, string fizz, string buzz, string tri)
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

            if (num % triNumber == 0)
            {
                s += tri;
            }
            return s ?? num.ToString();
        }
    }
}