using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("Type 'triangle' to check the type of a triangle or 'rectangle' to calculate the area of a rectangle.");
      string userResponse = Console.ReadLine();
      if (userResponse == "triangle" || userResponse == "Triangle")
      {
        Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();  
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();  
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();  
        int length1 = int.Parse(stringNumber1);  
        int length2 = int.Parse(stringNumber2);  
        int length3 = int.Parse(stringNumber3);  
        Triangle tri = new Triangle(length1, length2, length3);
        ConfirmOrEditTriangle(tri);
      }
      else
      {
        Console.WriteLine("We'll calculate the area of your rectangle by multiplying the lengths of two sides.");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();  
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine(); 
        int length1 = int.Parse(stringNumber1);  
        int length2 = int.Parse(stringNumber2);  
        Rectangle rec = new Rectangle(length1, length2);
        CalculateRectangleArea(rec);
      }
    }

    static void ConfirmOrEditTriangle(Triangle tri)
    {
      Console.WriteLine("Please confirm that you entered in your triangle correctly:");
      Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
      Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
      Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
      string userInput = Console.ReadLine();  
      if (userInput == "yes")
      {
        CheckTriangleType(tri);
      }
      else
      {
        Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();  
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();  
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();  
        tri.Side1 = int.Parse(stringNumber1);  
        tri.Side2 = int.Parse(stringNumber2);  
        tri.SetSide3(int.Parse(stringNumber3)); 
        ConfirmOrEditTriangle(tri);
      }
    }

    static void CheckTriangleType(Triangle tri)
    {
      string result = tri.CheckType();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new triangle (new)?");
      Console.WriteLine("Please enter 'new' to check the type of a new triangle, 'triangles' to see triangles checked so far, or any key to exit.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else if (userResponse == "triangles" || userResponse == "Triangles")
      {
        CheckTriangles();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }

    static void CalculateRectangleArea(Rectangle rec)
    {
      float result = rec.CalculateArea();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to calculate the area of a new rectangle (new)?");
      Console.WriteLine("Please enter 'new' to calculate the area of a new rectangle or any key to exit.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }

    static void CheckTriangles()
    {
      List<Triangle> allTriangles = Triangle.GetAll();
      int triangle = 1;
      Console.WriteLine("----------------------------------");
      foreach (Triangle tri in allTriangles)
      {
        Console.WriteLine($"Triangle {triangle}:");
        Console.WriteLine($"Side one of the triangle: {tri.Side1}");
        Console.WriteLine($"Side two of the triangle: {tri.Side2}");
        Console.WriteLine($"Side three of the triangle: {tri.GetSide3()}");
        Console.WriteLine("----------------------------------");
        triangle += 1;
      }
      Console.WriteLine("Please enter 'new' to check the type of a new triangle, 'clear' to clear all triangles and return to the beginning of the program, or any key to exit.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else if (userResponse == "clear" || userResponse == "Clear")
      {
        Triangle.ClearAll();
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}