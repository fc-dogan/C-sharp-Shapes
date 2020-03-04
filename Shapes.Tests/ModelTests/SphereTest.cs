using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTest
  {
    [TestMethod]
    public void Sphere_GetSphereVolume_VolumeSphere()
    {
      Circle newCircle = new Circle(3);
      Sphere newSphere = new Sphere(newCircle);
      double result = newSphere.GetSphereVolume();
      Assert.AreEqual(result, 113.04);
    }
    [TestMethod]
    public void Sphere_GetSphereSurfaceArea_SurfaceSphere()
    {
      Circle newCircle = new Circle(6);
      Sphere newSphere = new Sphere(newCircle);
      double result = newSphere.GetSphereSurfaceArea();
      Assert.AreEqual(result, 452.16);
    }
  }
}