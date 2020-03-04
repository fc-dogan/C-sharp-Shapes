using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTest
  {
    [TestMethod]
    public void Circle_GetDiameter_DiameterOfCircle()
    {
      Circle newCircle = new Circle(3);
      int result = newCircle.Diameter();
      Assert.AreEqual(result, 6);
    }

    [TestMethod]
    public void Circle_GetCircleArea_AreaOfCircle()
    {
      Circle newCircle = new Circle(3);
      double result = newCircle.CircleArea();
      Assert.AreEqual(result, 28.26);
    }
  }
}