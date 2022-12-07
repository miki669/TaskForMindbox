namespace TaskForMindbox.Shapes;

public class Triangle : IShapes
{

    public double A;
    public double B;
    public double C;
    public double P;
    public double S;
    
    /// <summary>
    /// Формула Герона
    /// </summary>
    /// Было бы разумно делать проверки на веденные данные юзера, но в задании об этом не было сказанно
    void IShapes.Calculate()
    {
        Console.WriteLine("Input a: ");
        A = double.Parse(Console.ReadLine());
        Console.WriteLine("Input b: ");
        B = double.Parse(Console.ReadLine());
        Console.WriteLine("Input c: ");
        C = double.Parse(Console.ReadLine());
        P = (A + B + C) / 2;
        S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        Console.WriteLine($"S = {S}" );
        if (A * A + B * B == C * C)
            Console.WriteLine("The triangle is rectangular");



    }
    
}