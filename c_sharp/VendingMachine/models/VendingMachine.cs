namespace VendingMachine.models
{
    class VendingMachine
    {
        /// <summary>
        /// 商品リスト
        /// </summary>
        List<Item>? items;

        /// <summary>
        /// 金銭管理
        /// </summary>
        MoneyManager moneyManager;



        /// <summary>
        /// お金の返金をする
        /// </summary>
        /// <returns>返金されるお金</returns>
        public int ReturnMoney()
        {
            return 0;
        }

        /// <summary>
        /// 商品の受け取り
        /// </summary>
        /// <returns>補充された商品</returns>
        public List<Item>? ReceiveItems()
        {
            return null;
        }

        /// <summary>
        /// お金の受け取り
        /// </summary>
        /// <returns>投入されたお金</returns>
        public int ReceiveMoney()
        {
            return 0;
        }

        /// <summary>
        /// 商品を出す
        /// </summary>
        /// <returns>購入された商品の情報</returns>
        public Item? PassItem()
        {
            return null;
        }
    }
}