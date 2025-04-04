DisplayAMonth();
DisplayAnotherMonth();
GetNumberBetween("Enter a number between 1 and 10", 1, 10);

// place methods at the bottom of main method for now
static void DisplayAMonth() {
  Console.WriteLine(Month.January);
}

static void DisplayAnotherMonth() {
  Console.WriteLine(Month.July);
}

// functions with parameters that return something
static int GetNumberBetween(string prompt, int min, int max) {
  int parsedNumber;

  do {
    Console.WriteLine(prompt);
    parsedNumber = Convert.ToInt32(Console.ReadLine());
  } while (parsedNumber < min || parsedNumber > max);

  return parsedNumber;
}


// enum goes at the bottom of the file
enum Month { January, February, March, April, May, June, July, August, September, October, November, December };