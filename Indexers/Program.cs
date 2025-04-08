Vector v = new Vector(5, 2);
double xComponent = v[0];
double yComponent = v[1];
Console.WriteLine("v[0]: " + xComponent + ", v[1]: " + yComponent);

Vector b = new Vector(8, 5);
double xComp = b["x"];
double yComp = b["y"];
Console.WriteLine("b['x']: " + xComp + ", b['y']: " + yComp);

public class Vector {
  public double X { get; set; }
  public double Y { get; set; }

  // this[] indicates indexing
  // we are defining an indexer which is essentially overloading
  // the default indexer
  public double this[int index] {
    get {
      if (index == 0) { return this.X; }
      else if (index == 1) { return this.Y; }
      else { throw new IndexOutOfRangeException(); }
    }
    set {
      if (index == 0) { this.X = value; }
      else if (index == 1) {  this.Y = value; }
      else { throw new IndexOutOfRangeException(); }
    }
  }

  // indexing with strings
  public double this[string component] {
    get {
      if (component == "x") { return this.X; }
      else if (component == "y") { return this.Y; }
      else { throw new IndexOutOfRangeException(); }
    }
    set {
      if (component == "x") { this.X = value; }
      else if (component == "y") { this.Y = value; }
      else { throw new IndexOutOfRangeException(); }
    }
  }

  // we can index with multiple indexers too
  public double this[string component, int index] {
    get {
      // do something if it makes sense
      // it doesn't make sense in this case so we just throw an exception
      throw new Exception();
    }
    set {
      // same as above
      throw new Exception();
    }
  }

  public Vector(double x, double y) {
    X = x;
    Y = y;
  }
}