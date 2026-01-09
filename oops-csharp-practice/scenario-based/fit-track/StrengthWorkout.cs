class StrengthWorkout : Workout, ITrackable
{
    public int reps { get; set; }
    public void Track()
    {
        Console.WriteLine("Evaluating Strength Workout");
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Repetitions: " + reps);

    }
}