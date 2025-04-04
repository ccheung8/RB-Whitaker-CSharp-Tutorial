Console.WriteLine("Hello, World!");

// making instances of the class
Player player1 = new Player("HAL 9000");
Player player2 = new Player("Tron");

// creating a class
class Player {
  // making class properties private is most common
  // starts with underscore to bypass scoping issues among others
  private string _name;
  private int _points;
  private int _livesLeft;

  // makes it so there's only one instance of this object, shared across classes
  private static int _pointsNeededForExtraLife = 1000;

  // class constructor
  public Player(string name) {
    _name = name;
    _points = 0;
    _livesLeft = 5;
  }

  // methods that allow viewing values without modifying
  public string GetName() { return _name; }
  public int GetPoints() { return _points; }
  public int GetLivesLeft() { return _livesLeft; }

  // you can have methods in classes too!
  // methods in class are typically UpperCamelCase
  // methods are often public (usually utility/helper methods are private)
  public void AddPoints(int amount) {
    int previousThousand = _points / _pointsNeededForExtraLife;
    _points += amount;
    int newThousand = _points / _pointsNeededForExtraLife;

    if (newThousand > previousThousand) {
      _livesLeft++;
    }
  }

  public void Kill() {
    _livesLeft--;
    if (_livesLeft == 0) {
      _points = 0;
    }
  }
}