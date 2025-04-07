// subscribing to events
Point a = new Point() { X = 3, Y = 2 };
// this part subscribes to the event
// += adds HandlePointChanged to set of methods to call when
// event is raised
a.Changed += HandlePointChanged;

// HandlePointChanged fires twice here
a.X = 5;
a.Y = 22;

// unsubscribing from an event
a.Changed -= HandlePointChanged;

static void HandlePointChanged(Point source) {
  Console.WriteLine("The point is now at (" + source.X + ", " + source.Y + ")");
}

public class Point {
  private double _x;
  private double _y;

  public double X {
    get { return _x; }
    set { 
      _x = value;
      // ? makes it so it only fires if changed isn't null
      Changed?.Invoke(this);  // raises event
    }
  }

  public double Y {
    get { return _y; }
    set { 
      _y = value;
      Changed?.Invoke(this);
    }
  }

  // Action is a delegate type included in the base library of C#
  // events are similar to eventlisteners in js
  // most events are public
  // [access modifier] event [delegate type] [event name]
  public event Action<Point> Changed;
}