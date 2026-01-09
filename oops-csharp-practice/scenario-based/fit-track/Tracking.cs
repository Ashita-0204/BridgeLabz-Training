using System;
class Tracking
{
    public static void Main()
    {
        // Create user
        User user = new User
        {
            id = 1,
            name = "Kaaa"
        };

        user.Display();

        // Polymorphism: base class reference
        Workout work = new CardioWorkout
        {
            WorkName = "Running",
            duration = 35,
            CalBurnt = 500
        };

        Workout work1 = new StrengthWorkout
        {
            WorkName = "Weight Training",
            duration = 25,
            reps = 50
        };

        work.Display();
        ((ITrackable)work).Track();
        // Strength workout
        work1.Display();
        ((ITrackable)work1).Track();
    }
}
