using TaskForMindbox.Shapes;

namespace TaskForMindbox;

public class Shape
{
    private IShapes? _shapes;
    
    public void SetShapes(IShapes shapes)
    {
        _shapes = shapes;
    }
    public void Calculates()
    {
        if (_shapes is null)
        {
            Console.WriteLine("Unable to calculate, select a shape! ");
            return;
        }
        _shapes.Calculate();
    }
}