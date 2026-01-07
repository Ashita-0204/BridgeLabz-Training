public class InPatient : Patient, IMedicalRecord
{
    public override double CalculateBill()
    {
        return 8000;
    }

    public void AddRecord(string rec)
    {
        Console.WriteLine("Record added");
    }

    public void ViewRecord()
    {
        Console.WriteLine("Viewing records");
    }
}