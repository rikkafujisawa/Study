using VendingMachine.models;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.CLI上で選択肢を出し、希望の処理を確認する。
            //例)0:~~、1:~~
            Console.WriteLine("0:商品の投入(業者用) 1:商品の表示(お客さん用)");
            string? input = Console.ReadLine();
            //2.入力された値ごとに処理を行う
            if (input == "0")
            {
                // 商品の投入処理を呼び出す
                VendingMachine.ReceiveItems();
            }
            else if (input == "1")
            {
                // 商品の表示処理を呼び出す
            }
            else
            {
                Console.WriteLine("0または1を入力してください");
            }
            //3.業者用：商品を受け取る。
            //4.お客さん用：
            // 商品を表示する。(在庫数)
            // お金を受け取る。
            // 入力された金額を表示する。
            // 返金・おつりボタンが押されたら入っているお金を返金する。
            // ボタンが押されたとき、商品の値段より多く金額が入っていて、在庫があったら商品を出す。
            // 返金・おつりボタンが押されたらお釣りを出す。
        }
    }
}