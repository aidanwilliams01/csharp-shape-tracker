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
      Rectangle newRectangle = new Rectangle(3);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnSide1_Int()
    {
      int length1 = 3;
      Rectangle newRectangle = new Rectangle(length1);
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Rectangle newRectangle = new Rectangle(3);
      int newLength1 = 44;
      newRectangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }
  }
}