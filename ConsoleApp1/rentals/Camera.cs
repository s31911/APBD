namespace ConsoleApp1.rentals;

public class Camera : Equipment
{
    
    public string Producent { get; set; }
    public int SensorSize { get; set; }

    public Camera()
    {
        
    }
        
    public Camera(string name,AvailabilityStatus status,string producent,int sensorSize) : base(name,status)
    {
        Producent = producent;
        SensorSize = sensorSize;
    }

    public override string ToString()
    {
        return base.ToString() + $"Producent {Producent}, SensorSize {SensorSize}" ;
    }
}