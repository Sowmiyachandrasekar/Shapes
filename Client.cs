using System;
public class Client
{
    public static void Main()
    {
        IShapes obj=new Circle();
        obj.GetArea();

        IShapes shape=new Rectangle();
        shape.GetArea();
    }
}