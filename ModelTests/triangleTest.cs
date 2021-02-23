using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeFinder;

namespace ShapeFinder.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_NotATriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("This shit ain't a triangle!", testTriangle.IsTriangle(2,2,4));
    }

    [TestMethod]
    public void IsTriangle_Equilateral_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("This is an equilateral triangle!", testTriangle.IsTriangle(2,2,2));
    }

    [TestMethod]
    public void IsTriangle_Isoceles_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("This is an isoceles triangle!", testTriangle.IsTriangle(2,2,3));
    }

    [TestMethod]
    public void IsTriangle_Scalene_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("That's some lame scalene triangle!", testTriangle.IsTriangle(2,3,4));
    }
  }
}