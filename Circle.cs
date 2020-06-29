using System;
public class Circle : IShapes
{
    public double radius=3.7;
    public void GetArea()
    {
        double _area = Math.PI*radius*radius;
        Console.WriteLine("The area of Circle is " + _area);
    }
}