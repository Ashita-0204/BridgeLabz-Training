using System;

class HospitalManagement
{
    // static variable
    public static string HospitalName = "City Hospital";
    private static int total = 0;
    // instance variables
    public string Name;
    public int Age;
    public string Ailment;

    // readonly variables
    public readonly int PatientId;

    // constructor 
    public HospitalManagement(string name, int age, string ailment, int id)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientId = id;
        total++;
    }

    // static method
    public static void GetTotal()
    {
        Console.WriteLine("Total Patients: " + total);
    }

    public void Display()
    {
        if (this is HospitalManagement)
        {
            Console.WriteLine(Name + " of age: " + Age + " has " + Ailment);
        }
    }

    public static void Main()
    {
        HospitalManagement patient = new HospitalManagement("Ashita", 21, "ADHD", 601);
        patient.Display();
        GetTotal();
    }
}
