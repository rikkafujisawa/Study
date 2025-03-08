// 自動販売機
class VendingMachine
{
    /// <summary>
    /// 商品リスト
    /// </summary>
    List<Item> items;

    /// <summary>
    /// 金銭管理
    /// </summary>
    MoneyManager moneyManager;

    /// <summary>
    /// お金の返金をする
    /// </summary>
    /// <returns></returns>
    public int returnMoney()
    { }

    /// <summary>
    /// 商品の受け取り
    /// </summary>
    /// <returns></returns>
    public List receiveItems()
    { }

    /// <summary>
    /// お金の受け取り
    /// </summary>
    /// <returns></returns>
    public int receiveMoney()
    { }

    /// <summary>
    /// 商品を出す
    /// </summary>
    /// <returns></returns>
    public List PassItem()
    { }
}