using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(3, 2);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnSide1_Int()
    {
      int length1 = 3;
      Rectangle newRectangle = new Rectangle(length1, 2);
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Rectangle newRectangle = new Rectangle(3, 3);
      int newLength1 = 44;
      newRectangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      int length2 = 3;
      Rectangle newRectangle = new Rectangle(2, length2);
      int result = newRectangle.Side2;
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      Rectangle newRectangle = new Rectangle(3, 4);
      int newLength2 = 6;
      newRectangle.Side2 = newLength2;
      Assert.AreEqual(newLength2, newRectangle.Side2);
    }

    [TestMethod]
    public void CalculateArea_ReturnsArea_Float()
    {
      Rectangle newRectangle = new Rectangle(5, 5);
      float area = newRectangle.CalculateArea();
      Assert.AreEqual(25, area);
    }
  }
}