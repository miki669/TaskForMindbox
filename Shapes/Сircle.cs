namespace TaskForMindbox.Shapes;

public class Сircle : IShapes
{
    public double Radius;
    
    /// <summary>
    /// s=пR^2 
    /// </summary>
    void IShapes.Calculate()
    {
        double S;
        Console.WriteLine("Input radius of the circle: ");
        Radius = double.Parse(Console.ReadLine());
        Console.WriteLine($"S circle = {Math.PI * Math.Pow(Radius, 2)}");
        
    }
}