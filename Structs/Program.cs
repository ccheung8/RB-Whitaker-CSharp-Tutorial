TimeStruct s = new TimeStruct();
s.Seconds = 120;
UpdateAndDisplayStruct(s);
Console.WriteLine(s.Seconds); // still stays at 120

TimeClass c = new TimeClass();
c.Seconds = 120;
UpdateAndDisplayClass(c);
Console.WriteLine(c.Seconds); // gets altered to 130

static void UpdateAndDisplayStruct(TimeStruct timeStruct) {
  timeStruct.Seconds += 10;
  Console.WriteLine(timeStruct.CalculateMinutes());
}

static void UpdateAndDisplayClass(TimeClass timeClass) {
  timeClass.Seconds += 10;
  Console.WriteLine(timeClass.CalculateMinutes());
}

// value type
// use structs for small things that are data-focused and relatively small
// example: x, y coordinates on a 2D plane
struct TimeStruct {
  public int Seconds {  get; set; }
  public int CalculateMinutes() {
    return Seconds / 60;
  }
}

// reference type
// use classes if there's lots of behaviors
// classes are way more common than structs
class TimeClass {
  public int Seconds { get; set; }
  public int CalculateMinutes() {
    return Seconds / 60;
  }
}