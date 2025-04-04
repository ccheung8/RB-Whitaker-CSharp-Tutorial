// non mandatory values can be set during creation
Rectangle rectangle = new Rectangle(5, 6) { SomeFloat = 100.0f };
Console.WriteLine(rectangle.SomeFloat);
rectangle.Width++;
Console.WriteLine(rectangle.Width);

rectangle.Height = 20;
Console.WriteLine(rectangle.Height);

class Rectangle {
  private float _width;
  private float _height;
  private float _someFloat;

  // c# property
  // the same as a GetWidth() and SetWidth() function with the advantage of
  // being able to access the property like they're public
  public float Width {
    get { return _width; }
    set { _width = value; }
  }


  public float Height {
    get { return _height; }
    set { _height = value; }
  }

  // c# property for rectangle.Area
  public float Area { get { return _width * _height; } }

  // auto property
  // this is equivalent to the properties above
  public float SomeFloat { get; set; }

  // accessibility levels can be varied
  // get is public but set is private
  public float SomeProperty {
    get { return _width; }
    private set { _width = value; }
  }

  public Rectangle(float width, float height) {
    _width = width;
    _height = height;
  } 
}