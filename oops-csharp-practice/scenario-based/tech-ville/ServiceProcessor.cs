using System;

public static class ServiceProcessor
{
    // Polymorphism using interface
    public static void ProcessBooking(IBookable service)
    {
        service.BookService("Ashita");
    }

    public static void ProcessCancellation(ICancellable service)
    {
        service.CancelBooking(1);
    }

    public static void ProcessTracking(ITrackable service)
    {
        service.TrackStatus(1);
    }
}