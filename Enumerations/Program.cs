// enums are accessed like this
DayOfWeek today = DayOfWeek.Thursday;

// casting enums
int dayAsInt = (int)DayOfWeek.Sunday;
DayOfWeek tomorrow = (DayOfWeek)(dayAsInt + 1);
Console.WriteLine(tomorrow.ToString());

// enums are declared at the bottom of document
public enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
// enums are numbered by default similar to arrays but they can be assigned numbers