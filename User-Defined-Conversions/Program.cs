// this works thanks to our implicit conversion
int aNumber = 3;
MagicNumber magicNumber = aNumber;
Console.WriteLine("MagicNumber object: " + magicNumber.Number + ", " + magicNumber.IsMagic);

// this works thanks to our explicit conversion
MagicNumber magicNumber1 = new MagicNumber() { Number = 3, IsMagic = true };
int aNumber1 = (int)magicNumber1;
Console.WriteLine(aNumber1);

public class MagicNumber {
  public int Number {  get; set; }
  public bool IsMagic {  get; set; }

  // converts an int to a MagicNumber
  // must be marked public and static
  // we specify implicit or explicit
  // implicit means it convers automatically on assignment
  // public static [implicit/explicit] operator [type that's being converted](what's being converted from)
  public static implicit operator MagicNumber(int value) {
    return new MagicNumber() { Number = value, IsMagic = false };
  }

  // explicit cast from MagicNumber to int
  public static explicit operator int(MagicNumber magicNumber) {
    return magicNumber.Number;
  }
}