using System;
class PartTimeEmp : Employee
{
    private int workedhr;
    private double hrRate;
    public PartTimeEmp(int hour, int rate)
    {
        workedhr = hour;
        hrRate = rate;
    }

    public override int CalculateSalary()
    {
        return workedhr * hrRate;
    }
}