namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Area {get;set;}
    public Sphere (Circle bisection)
    {
      Area = bisection;
    }
    public double GetSphereVolume()
    {
      double radius = Area.Radius;
      double volume = (4 * 3.14 * (radius * radius * radius)) / 3;
      return volume;
    }
    public double GetSphereSurfaceArea()
    {
      double radius = Area.Radius;
      double surfaceArea = 4 * 3.14 * (radius * radius);
      return surfaceArea;
    }

  }
}