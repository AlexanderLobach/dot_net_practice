using System;

abstract class Figure
{    
    public abstract string Area();
    public abstract string Name();
}
class Circle : Figure
{
     public Circle (double radius)
    {
        this.Radius = radius;
    }
    public double Radius {get; set;} 
    public override string Area()
    {
        double area = Math.PI * Math.Pow(Radius, 2);
        return string.Format("{0:f2}", area);
    }

    public override string Name() => "Circle";
    }
class Square : Figure
{
    public Square (double side)
    {
        this.Side = side;
    }
    public double Side {get; set;}
    public override string Area()
    {
        double area = Math.Pow(Side, 2);
        return string.Format("{0:f2}", area);
    }
        public override string Name() => "Square";
}
class Triangle : Figure
{
    public Triangle (double side)
    {   
        this.Side = side;
    }
    public double Side {get; set;}
    public override string Area()
    {   
        double area = Math.Pow(Side, 2) * Math.Sqrt(3) / 4;
        return string.Format("{0:f2}", area);
    }
    public override string Name() => "Triangle";
}
    
 
   
