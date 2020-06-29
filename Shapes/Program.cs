using System;

public interface IShape
{
    void Area();
}
public class Rectangle:IShape
{
    double Length, Breadth, area;
       public void Area()
    {
        Console.WriteLine("Enter length of rectangle : ");
        Length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter breadth of rectangle : ");
        Breadth = Convert.ToDouble(Console.ReadLine());

        area = Length * Breadth;
        Console.WriteLine("Area of a Rectangle is" + area);
    }
}
public class Circle : IShape
{
    double Radius, area;
    public void Area()
    {
        Console.WriteLine("Enter the Radius of a circle : ");
        Radius = Convert.ToDouble(Console.ReadLine());

        area = Math.PI * Radius * Radius;
        Console.WriteLine("Area of a circle is" + area);
    }
}
public class Square: IShape
{
    double side, area;
    public void Area()
    {
        Console.WriteLine("Enter the side of a square : ");
        side = Convert.ToDouble(Console.ReadLine());

        area = side * side;
        Console.WriteLine("Area of a Square is" + area);

    }

}
public class GetArea
{
    public static void Main()
    {
        IShape R = new Rectangle();
        R.Area();

        IShape C = new Circle();
        C.Area();

        IShape S = new Square();
        S.Area();

    }
}

