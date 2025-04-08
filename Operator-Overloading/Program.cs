Vector a = new Vector(5, 2);
Vector b = new Vector(-3, 4);
Vector result = a + b;  // vector + operator overload here
Console.WriteLine("result.X: " + result.X + "\nresult.Y: " + result.Y);

// Operators that can be overloaded:
// +, -, *, /, %, ++, --, ==, !=, <, >, <=, >=

// += and *= aren't directly overloadable, but overloading
// + or * modifies their behavior

// relational operators must be overloaded in pairs
// ex. if you overload ==, != must also be overloaded

public class Vector {
  public double X {  get; set; }
  public double Y { get; set; }
  
  // overloading + operator
  // all operator overloads must be public and static
  // operator keyword means we're making a new  operator
  public static Vector operator +(Vector v1, Vector v2) {
    return new Vector(v1.X + v2.X, v1.Y + v2.Y);
  }

  // overloads negative operator
  public static Vector operator -(Vector v) {
    return new Vector(-v.X, -v.Y);
  }

  // overloading relational operators must return a bool
  public static bool operator ==(Vector v1, Vector v2) {
    return ((v1.X == v2.X) && (v1.Y == v2.Y));
  }

  // when reloading ==, != must be reloaded too
  public static bool operator !=(Vector v1, Vector v2) {
    return !(v1 == v2);
  }

  public Vector(double x, double y) {
    X = x;
    Y = y;
  }
}