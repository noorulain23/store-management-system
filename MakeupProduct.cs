public class MakeupProduct : Product
{
    public string expiryDate;
    public MakeupProduct(string name, string weight, string expiryDate, int buyingPrice, int sellingPrice)
    : base(name, weight, expiryDate, buyingPrice, sellingPrice)
    {
        
    }

}