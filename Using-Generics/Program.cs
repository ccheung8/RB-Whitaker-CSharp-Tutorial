// List<T> Class
// This is a generic List class where <T> can be replaced by any type
// Example with a list of ints
List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);
Console.WriteLine(numbers[0]);
numbers.RemoveAt(0); // removes at index 0 (10)
Console.WriteLine(numbers.Count);

// Example with a list of strings
List<string> words = new List<string>();
words.Add("apple");
words.Add("banana");
words.Add("cherry");

foreach (string word in words) {
  Console.WriteLine(word);
}

words.Remove("cherry");
words.Clear();  // removes everything

// Using the Dictionary Class
// Dictionary<K, V> has 2 generic type parameters
// useful for loking up one set of things from another
Dictionary<int, string> englishWords = new Dictionary<int, string>();
englishWords[0] = "zero";
englishWords[1] = "one";
englishWords[10] = "ten";
englishWords[100] = "one hundred";
Console.WriteLine("The word for 100 is " + englishWords[100]);
englishWords.Remove(10);
Console.WriteLine("I know " + englishWords.Count + " words for numbers.");