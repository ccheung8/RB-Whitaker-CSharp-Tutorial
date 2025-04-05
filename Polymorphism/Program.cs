Player player1 = new HumanPlayer();
Player player2 = new RandomAIPlayer();

public enum MoveDirection { None, Left, Right, Up, Down }

// abstract keyword makes it so that people can't create a player object
// they need to create either a HumanPlayer or RandomAIPlayer
// aka Player player1 = new Player(); is not allowed
abstract class Player {
  // virtual allows derived classes to change the way this method is defined
  public virtual MoveDirection MakeMove() {
    return MoveDirection.Left;  // default is set to move left
  }
}

class HumanPlayer : Player {
  // this method overrides the MakeMove() method in the player class if a Player object is a HumanPlayer
  public override MoveDirection MakeMove() {
    ConsoleKeyInfo info = Console.ReadKey();

    // if we want to use the MakeMove() method in the Player class, we can use the
    // base keyword
    base.MakeMove();

    if (info.Key == ConsoleKey.LeftArrow) { return MoveDirection.Left; }
    if (info.Key == ConsoleKey.RightArrow) { return MoveDirection.Right; }
    if (info.Key == ConsoleKey.UpArrow) { return MoveDirection.Up; }
    if (info.Key == ConsoleKey.DownArrow) { return MoveDirection.Down; }

    return MoveDirection.None;
  }
}

class RandomAIPlayer : Player {
  private Random _random;

  public RandomAIPlayer() {
    _random = new Random();
  }

  public override MoveDirection MakeMove() {
    // switch expression + enumeration
    return _random.Next(4) switch {
      0 => MoveDirection.Left,
      1 => MoveDirection.Right,
      2 => MoveDirection.Up,
      _ => MoveDirection.Down
    };
  }
}

class RandomPlayer : Player {
  // new keyword makes it so that class is not overridden and it is its own thing
  // THIS SHOULD BE EXTREMELY RARE AS IT CAN CAUSE CONFUSION
  // override is the norm
  public new MoveDirection MakeMove() {
    // some stuff
    return MoveDirection.None;
  }
}