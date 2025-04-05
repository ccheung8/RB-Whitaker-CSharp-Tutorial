// using derived and base classes
Polygon polygon = new Polygon(3);
Square square = new Square(4.5f);

// square is a polygon, so this works too
// HOWEVER: it only has access to polygon properties, not square
Polygon polygon1 = new Square(4.5f);

// check object type and cast
// it's best practice to check before casting
if (polygon1 is Square) {
  //Square square1 = (Square)polygon1;
  // do whatever
}

// shorthand version of the above
if (polygon1 is Square square1) {
  // do whatever
}

// inheritance works in arrays too
Polygon[] lotsOfPolygons = new Polygon[3];
lotsOfPolygons[2] = new Square(2.1f);

// every object in c# is derived from the object class
// this gives you access to the ToString() method
object anyOldObject = new Square(4.5f);

// base class (also called superclass or parent class)
class Polygon {
  // protected means the base, as well as any derived class can access it
  // Polygon and Square can access NumberOfSides in this situation
  protected int NumberOfSides {  get; set; }

  public Polygon() {
    NumberOfSides = 0;
  }

  public Polygon(int numberOfSides) {
    NumberOfSides = numberOfSides;
  }
}

// derived class (aka subclass)
// square is a subclass of polygon
// sealed makes it so nothing can inherit from this class
// sealed can result in a performance boost
sealed class Square : Polygon {
  public float Size { get; set; }

  // base(4) is same as saying NumberOfSides = 4 or new Polygon(4)
  // similar to super() in js
  // sets NumberOfSides in parent (Polygon) class to 4
  public Square (float size) : base(4) {
    Size = size;
  }
}