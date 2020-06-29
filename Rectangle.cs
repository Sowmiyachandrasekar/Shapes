using System;
public class Rectangle : IShapes
{
    public float Length=10;
    public float Width=2;
    public void GetArea()
    {
        float _area = Length*Width;
        Console.WriteLine("The area of Rectangle is " +_area);
    }
    
}