public abstract class Patient
{
    private int patientId;
    private string name;
    protected int age;
    public abstract int CalculateBill();
    public void GetPatientDetail()
    {
        Console.WriteLine("Patient name: " + name);
    }
}