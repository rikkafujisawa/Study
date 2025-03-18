// 自動販売機表示
class VendingMachineDisplay
{
    /// <summary>
    /// 商品リスト
    /// </summary>
    List<Item>? Items;

    /// <summary>
    /// 入金された金額
    /// </summary>
    private int InsertMoney;

    private void Debug()
    {
        Console.WriteLine(InsertMoney);
    }


    /// <summary>
    /// 商品を表示
    /// </summary>
    /// <returns>表示する商品の情報</returns>
    public List<Item>? DisplayItems()
    {
        return null;
    }

    /// <summary>
    /// 金額を表示
    /// </summary>
    /// <returns>表示するお客さんの投入した金額</returns>
    public int DisplayMoney()
    {
        return 0;
    }
}