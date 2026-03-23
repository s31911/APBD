namespace ConsoleApp1.rentals;

public class Projector : Equipment
{
    public int Brightness { get; set; }
    public string Resolution { get; set; }

    public Projector(string name, AvailabilityStatus status, int brightness, string resolution) : base(name, status)
    {
        Brightness = brightness;
        Resolution = resolution;
    }
    
    
}