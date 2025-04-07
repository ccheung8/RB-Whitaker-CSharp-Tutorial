Console.WriteLine("Enter a number:");
string userInput = Console.ReadLine();

// try catch for if there's issues converting userInput to int32
try {
  // code that may cause issues
  int number = Convert.ToInt32(userInput);

  // if there is an error with the above code, the program would
  // jump to the catch block and any code below wouldn't be executed
} catch(Exception e) { // this only handles certain exceptions. we can choose what exceptions to handle
  // code to handle the problem
  // this doesn't execute if there's no issues
  Console.WriteLine("Please enter a number");
}

// handling multiple errors example
try {
  int number = Convert.ToInt32(userInput);
  // catch blocks are ordered from most to least specific
} catch (FormatException) {
  Console.WriteLine("Please enter a number");
} catch (OverflowException) {
  Console.WriteLine("Enter a smaller number");
} catch (Exception) {
  Console.WriteLine("An unknown error occurred");
}

// try catch finally block
try {
  // do some stuff that could throw an exception
} catch (Exception) {
  // handle the exception
} finally {
  // this code always gets executed regardless of what happens in the try/catch
}

// throwing exceptions
void CauseProblems() {
  throw new Exception("Just doing my job!");
}

// throw exception for our newly created exception
throw new AteTooManyHamburgersException(125);

// you can make your own exceptions!
public class AteTooManyHamburgersException : Exception {
  public int HamburgersEaten { get; }

  public AteTooManyHamburgersException(int hamburgersEaten) {
    HamburgersEaten = hamburgersEaten;
  }
}