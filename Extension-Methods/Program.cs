Console.WriteLine("Sun's getting real low.".ToRandomCase());

// may be good practice to name the class [object type] + Extensions
// needs to be static
public static class StringExtensions {
  private static Random random = new Random();
  
  // first param must be type of object we're creating the extension
  // method for
  public static string ToRandomCase(this string text) {
    string result = "";

    for (int i = 0; i < text.Length; i++) {
      if (random.Next(2) == 0) {
        result += text.Substring(i, 1).ToUpper();
      } else {
        result += text.Substring(i, 1).ToLower();
      }
    }

    return result;
  }
}