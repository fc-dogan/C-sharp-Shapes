using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CubeTests
  {

    [TestMethod]
    public void Cube_GetVolume_VolumeOfCube()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(4, 4); // instance od the Rectangle class
      Cube newCube = new Cube(newRectangle);        // instance of the Cube class
      // Act
      int result = newCube.GetVolume();  // call GetVolume() on the new instance of Cube
      // Assert
      Assert.AreEqual(result, 64);
    }

    [TestMethod]
    public void Cube_GetSurfaceArea_SurfaceAreaOfCube()
    {
       // Arrange
      Rectangle newRectangle = new Rectangle(4, 4);
      Cube newCube = new Cube(newRectangle);
      // Act
      int result = newCube.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 96);
    }

  }  
}