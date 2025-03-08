class Item
{
    /// <summary>
    /// 商品名
    /// </summary>
    string name;

    /// <summary>
    /// 値段
    /// </summary>
    int price;

    /// <summary>
    /// 数量
    /// </summary>
    int quantity;

    /// <summary>
    /// 商品のボタンの位置情報
    /// </summary>
    /// <remarks>
    /// 表示ディスプレイの一番左上を0として、Zの順番で数値がくり上がります。
    /// ex)0,1,2
    ///    3,4,5
    ///    6,7,8
    /// </remarks>
    int position;

    // /// <summary>
    // /// 賞味期限
    // /// </summary>
    DateTime expirationDate;
}