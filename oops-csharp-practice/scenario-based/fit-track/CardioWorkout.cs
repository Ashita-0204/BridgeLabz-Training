class CardioWorkout : Workout, ITrackable
{
    public int CalBurnt { get; set; }
    public void Track()
    {
        Console.WriteLine("Evaluating Cardio Workout");
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Calories Burned: " + CalBurnt);
    }
}
