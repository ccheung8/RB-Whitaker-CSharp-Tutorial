IFileWriter[] fileWriters = new IFileWriter[3];
fileWriters[0] = new TextFileWriter();

// Interfaces list a set of methods that classes who use it are committed to providing
// interface names commonly start with an "I"
public interface IFileWriter {
  string Extension { get; }
  void Write(string filename);
}

public class TextFileWriter : IFileWriter {
  public string Extension {
    get { return ".txt"; }
  }

  // imeplements Write method from interface
  // needs to be public
  public void Write(string filename) { 
    // do file writing...
  }
}

// // C#'s solution to multiple inheritance
// // multiple interfaces can be used if a class derives from person and noisemaker interfaces
// // if there's a base class, it must come first in the list
// public class Musician : IPerson, INoiseMaker {
//   // some stuff...
// }