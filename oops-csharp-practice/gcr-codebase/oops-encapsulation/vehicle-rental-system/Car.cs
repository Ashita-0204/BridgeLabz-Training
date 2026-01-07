public class Car : Vehicle, IInsurable
{
    public Car()
    {
        rentalRate = 1500;
    }
    public override int CalculateRentalCost(int day)
    {
        return rentalRate * day;
    }
    public int CalculateInsurance()
    {
        return 100;
    }
    public string GetInsuranceDetail()
    {
        return "The insurance is applied";
    }
}