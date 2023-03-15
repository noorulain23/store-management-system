public class Fragrance : Product
{
    public Fragrance(string name, string weight, string expiryDate, int buyingPrice, int sellingPrice)
    : base(name, weight, expiryDate, buyingPrice, sellingPrice)
    {

    }
    public override int NetProfit()
    {
        netProfit = sellingPrice - buyingPrice;
        netProfit = (int)(netProfit - (0.1f * netProfit));
        return netProfit;
    }
}