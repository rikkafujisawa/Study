namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz");
            Console.WriteLine("任意の倍数の時に、任意のテキストに置き換えることができるプログラムです。");
            Console.WriteLine("また、この処理を3つ設定でき、それぞれの約数の時に両方のテキストを足して表示します。");

            int start = GetValidIntReadLine("startの値を入力してください", n => n > 0, "数値を入力してください。"); // 入力受付

            int end = GetValidIntReadLine("endの値を入力してください", n => n > start, "startの値よりも小さい数値が入力されている、または数値が入力されていません。再度入力してください。"); // 入力受付

            int fizzNumber = GetValidIntReadLine("最初の倍数を入力してください", n => n < end, "endの値よりも大きい数値が入力されている、または数値が入力されていません。再度入力してください。"); // 入力受付

            int buzzNumber = GetValidIntReadLine("2つ目の倍数を入力してください", n => n < end && fizzNumber != n, "endの値よりも大きい数値が入力されている、または最初の倍数と同じ値になっている、または数値が入力されていません。再度入力してください。");

            int triNumber = GetValidIntReadLine("3つ目の倍数を入力してください", n => n < end && fizzNumber != n && buzzNumber != n, "endの値よりも大きい数値が入力されている、または既に入力した倍数と同じ値になっている、または数値が入力されていません。再度入力してください。"); // 入力受付

            string fizzWord = GetValidStringReadLine("最初の倍数を置き換えるテキストを入力してください", s => s != "", "文字列が入力されていません。再度入力してください。"); // 入力受付

            string buzzWord = GetValidStringReadLine("2つ目の倍数を置き換えるテキストを入力してください", s => s != fizzWord, "文字列が入力されていません。再度入力してください。");

            string triWord = GetValidStringReadLine("3つ目の倍数を置き換えるテキストを入力してください", s => s != fizzWord && s != buzzWord, "文字列が入力されていません。再度入力してください。"); // 入力受付

            for (var i = start; i <= end; i++)
            {
                Console.WriteLine(FizzBuzz(i, fizzNumber, buzzNumber, triNumber, fizzWord, buzzWord, triWord));
            }
        }

        /// <summary>
        /// 数値のバリデーション
        /// </summary>
        /// <param name="announceMessage">入力内容の説明</param>
        /// <param name="validator">追加する条件</param>
        /// <param name="errorMessage">バリデーターを通らなかった時のメッセージ</param>
        /// <returns>検証済みの数値</returns> 
        private static int GetValidIntReadLine(string announceMessage, Func<int, bool> validator, string errorMessage)
        {
            Console.WriteLine(announceMessage);
            while (true)
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int num) && num > 0 && validator(num))
                {
                    return int.Parse(input);
                }
                Console.WriteLine(errorMessage);
            }
        }

        /// <summary>
        /// 文字列のバリデーション
        /// </summary>
        /// <param name="announceMessage">入力内容の説明</param>
        /// <param name="validator">追加する条件</param>
        /// <param name="errorMessage">バリデーターを通らなかった時のメッセージ</param>
        /// <returns>検証済みのメッセージ</returns> 
        private static string GetValidStringReadLine(string announceMessage, Func<string, bool> validator, string errorMessage)
        {
            Console.WriteLine(announceMessage);
            while (true)
            {
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out int num) && num == 0 && input != "" && input != null && validator(input))
                {
                    return input;
                }
                Console.WriteLine(errorMessage);
            }
        }

        /// <summary>
        /// フィズバズの出力の値を作る
        /// </summary>
        /// <param name="num">判定対象の数値</param>
        /// <param name="fizzNumber">置き換える最初の倍数</param>
        /// <param name="buzzNumber">置き換える2つ目の倍数</param>
        /// <param name="triNumber">置き換える3つ目の倍数</param>
        /// <param name="fizz">最初の倍数の時の置き換える文字列</param>
        /// <param name="buzz">2つ目の倍数の時の置き換える文字列</param>
        /// <param name="tri">3つ目の倍数の時の置き換える文字列</param>
        /// <returns>出力する数値 or 置き換えた文字列</returns>
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
}//test
