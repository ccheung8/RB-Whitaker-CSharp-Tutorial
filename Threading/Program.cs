// GOAL: make a multithreaded application that performs the below code
//int[] numbers = new int[1000];
//Random random = new Random();
//for (int i = 0; i < numbers.Length; i++) {
//  numbers[i] = random.Next(100);
//}

int[] numbers = new int[10000];

// number of threads we want
int threadCount = 10;
// tasks for each thread to work on
GenerateNumbersTask[] tasks = new GenerateNumbersTask[threadCount];
// list of threads
Thread[] threads = new Thread[threadCount];

for (int i = 0; i < threadCount; i++) {
  // create task object and set parameters
  tasks[i] = new GenerateNumbersTask() {
    Numbers = numbers,
    Count = 1000,
    StartIndex = i * 1000,
  };

  // create thread
  threads[i] = new Thread(tasks[i].GenerateNumbers);

  // start the thread
  // if the method has a param, pass it in start()
  threads[i].Start();
}

// wait and join all threads so that when we move on,
// we're sure all the work is done
for (int i = 0; i < threadCount; i++) {
  threads[i].Join();
}

public class GenerateNumbersTask {
  private static Random random = new Random();

  // for threadlocking example
  // lock objects are usually private since they shouldn't be reused
  private object _threadLock = new object();
  int nextObject;
  
  public int[] Numbers { get; set; }
  public int StartIndex { get; set; }
  public int Count { get; set; }

  public void GenerateNumbers() {
    for (int i = StartIndex; i < StartIndex + Count; i++) {
      Numbers[i] = random.Next(100);
    }
  }

  public int GetNextObjectNumber() {
    int nextNumber;
    // ensures one thread runs this code to completion beofre another thread starts
    lock (_threadLock) {
      nextNumber = nextObject;
      nextObject++;
    }
    return nextNumber;
  }
}