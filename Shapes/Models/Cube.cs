namespace Shapes.Models
{
  public class Cube
  {
    public Rectangle Face { get; set;}        // rectangle object representing one face of the cube 
    public Cube(Rectangle side)             
    {
      Face = side;
    }
    public int GetVolume()   //to calculate the volume of a Cube, calling the Rectangle property Length from within Cube class
    {
      int length = Face.Length;
      return length * length * length;
    }
    public int GetSurfaceArea()
    {
      int length = Face.Length;
      return (length * length) * 6;
    }  

  }
}