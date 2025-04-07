// info to be written to txt
string informationToWrite = "Hello persistent file storage world";
// writing text to txt in specified path
File.WriteAllText("C:/Users/drago/Desktop/test1.txt", informationToWrite);

// array of strings to insert into file
string[] arrayOfInformation = new string[2];
arrayOfInformation[0] = "This is line 1";
arrayOfInformation[1] = "This is line 2";
// writes all text in array separated by newline
File.WriteAllLines("C:/Users/drago/Desktop/test2.txt", arrayOfInformation);

// read text files
string fileContents = File.ReadAllText("C:/Users/drago/Desktop/test1.txt");
string[] fileContentsByLine = File.ReadAllLines("C:/Users/drago/Desktop/test2.txt");

// creating a CSV of HighScore objects
List<HighScore> scores = new List<HighScore>();
// populate scores with data
scores.Add(new HighScore("Debbie", 500));
scores.Add(new HighScore("John", 5000));
scores.Add(new HighScore("Pepechu", 9000));
string allHighScoresText = "";
// concats strings of csv data into allHighScoresText
foreach (HighScore score in scores) {
  allHighScoresText += score.Name + "," + score.Score + "\n";
}
// outputs data into a csv file
File.WriteAllText("C:/Users/drago/Desktop/highscores.csv", allHighScoresText);

// reading a csv
string[] highScoresText = File.ReadAllLines("C:/Users/drago/Desktop/highscores.csv");
HighScore[] highScores = new HighScore[highScoresText.Length];
for (int i = 0; i < highScoresText.Length; i++) {
  // stores into an array high scores separated by comma
  string[] tokens = highScoresText[i].Split(',');

  // stores first element into name
  string name = tokens[0];
  // stores second element into token
  int score = Convert.ToInt32(tokens[1]);

  // uses info to create new HighScore object in highScores array
  highScores[i] = new HighScore(name, score);
}

class HighScore {
  //private string _name;
  //private int _score;

  public string Name { get; set; }

  public int Score { get; set; }

  public HighScore() {
    Name = "New Player";
    Score = 0;
  }

  public HighScore(string name) {
    Name = name;
    Score = 0;
  }

  public HighScore(string name, int score) {
    Name = name;
    Score = score;
  }
}