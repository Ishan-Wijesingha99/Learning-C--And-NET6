
using System;



namespace Loops {

  class LoopsClass {

    static void Main(string[] args) {
      
      // for-loop
      // literally the same as in javascript
      // the value of i is incremented at the end of each iteration
      for(int i=0; i < 10; i++) {
        System.Console.WriteLine("i is equal to {0}", i);
      }
      System.Console.WriteLine("First for-loop completed");

      for(int i=0; i <= 50; i+=7) {
        System.Console.WriteLine("i is equal to {0}", i);
      }
      System.Console.WriteLine("Second for-loop completed");



      // while-loop
      // literally the same as javascript
      // checks to see if condition is met, if it is, codeblock is executed, this repeats
      int whileLoopCounter = 0;

      while(whileLoopCounter < 18) {
        System.Console.WriteLine(whileLoopCounter);
        whileLoopCounter++;
      }

      System.Console.WriteLine("While-loop completed");


      // do-while loop
      // literally the same as javascript
      // codeblock is run first, then checks to see if condition is met, if it is, codeblock run again, if not it stops
      int counter = 0;

      do {
        counter++;
        System.Console.WriteLine("counter is at {0}", counter);
      } while(counter < 6);

      System.Console.WriteLine("do-while loop completed");



      // execute challenge function
      ChallengeFunction();

      // execute BreakAndContinue function
      BreakAndContinue();
    }

    // create function that increments counter by 1 and prints result to the console when the user clicks enter 
    public static void ChallengeFunction() {
      int counter = 0;

      while(counter < 21) {
        System.Console.WriteLine("Please press enter to increment count by 1");
        string userInput = Console.ReadLine();

        if(userInput.Equals("")) {
          counter++;
          System.Console.WriteLine(counter);
        }
      }
    }

    

    // break and continue in loops
    public static void BreakAndContinue() {
      
      for(int i=0; i<10; i++) {

        if(i == 6) {
          // this will stop the loop completely
          break;
        }

        System.Console.WriteLine(i);
      }

      for(int i=0; i<10; i++) {

        if(i == 6) {
          // this will skip the current iteration
          continue;
        }

        System.Console.WriteLine(i);
      }
    
    }
    
  }

}