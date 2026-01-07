using System;
class Electronics : Product, ITaxable
{
    public Electronics(int p)
    {
        price = p;
    }
    public override int CalculateDiscount()
    {
        return price * 0.10;
    }
    public int CalculateTax()
    {
        return price * 0.18;
    }
    public string GetTaxDetail()
    {
        return "20% GST";
    }
}