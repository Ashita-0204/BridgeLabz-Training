class NonOptimizedCuttingStrategy : CuttingStrategy
{
    // Returns the price of the rod without any cuts.
    public override int CalculateRevenue(Rod rod, PriceChart chart)
    {
        return chart.GetPrice(rod.Length);
    }
}
