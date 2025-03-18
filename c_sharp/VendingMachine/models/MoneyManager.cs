namespace VendingMachine.models
{
    // 金銭処理
    class MoneyManager
    {
        /// <summary>
        /// 入金された金額
        /// </summary>
        int insertMoney;

        /// <summary>
        /// お金の限度額
        /// </summary>
        int limitAmount;

        // private void Debug()
        // {
        //     Console.WriteLine(limitAmount);
        //     Console.WriteLine(insertMoney);
        // }

        /// <summary>
        /// 金額などの計算
        /// </summary>
        /// <returns></returns>
        public int Calculate()
        {
            return 0;
        }

        /// <summary>
        /// お金が足りているかの確認
        /// </summary>
        /// <returns>お釣り</returns>
        public int PayBill()
        {
            return 0;
        }
    }
}