int[] numbers = new int[] { 1, 2, 3, 4, 5 };
// pass in the name of the method with parenthesis
ModifyArray(numbers, AddOne);
ModifyArray(numbers, Double);
ModifyArray(numbers, TripleAndAddOne);

static int AddOne(int input) { return input + 1; }
static int Double(int input) { return input * 2; }
static int TripleAndAddOne(int input) { return input * 3 + 1; }

// the goal is to combine all of the methods above into one
static void ModifyArray(int[] numbers, NumberDelegate desiredChange) {
  for (int i = 0; i < numbers.Length; i++) {
    numbers[i] = desiredChange(numbers[i]);
  }
}

// delegates go on the bottom of the file along with enumeration, class, struct
// and interface definitions
// the int input parameter comes from a common theme among the other methods
public delegate int NumberDelegate(int input);