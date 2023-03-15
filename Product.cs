public class Product
{
    public string productName;
    public string weight;
    public string expiryDate;
    public int buyingPrice;
    public int sellingPrice;
    public int netProfit;
    public Product(string productName, string weight, string expiryDate, int buyingPrice, int sellingPrice)
    {
        this.productName = productName;
        this.weight = weight;
        this.expiryDate = expiryDate;
        this.buyingPrice = buyingPrice;
        this.sellingPrice = sellingPrice;
    }
    public virtual int NetProfit()
    {
        netProfit = sellingPrice - buyingPrice;
        return netProfit;
    }


}
