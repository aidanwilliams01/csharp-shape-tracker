namespace ShapeTracker.Models
  {
    public class Rectangle
    {
      private int _side1;
      public int Side1
      {
        get { return _side1; }
        set { _side1 = value; }
      }
      
      public Rectangle(int length1)
      {
        _side1 = length1;
      }
    }
  }