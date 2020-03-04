using System;

namespace Shapes.Models
{
  public class Circle
  {
    public int Radius { get; set;}

    public Circle(int radius)
    {
      Radius = radius;
    }

    public int Diameter()
    {
      return Radius * 2;
    }

    public double CircleArea()
    {
      double result = Radius * Radius * 3.14;
      return result;
    }
  }


}