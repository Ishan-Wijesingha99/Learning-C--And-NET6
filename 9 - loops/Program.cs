
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
      



      // do-while loop
      // literally the same as javascript
      // codeblock is run first, then checks to see if condition is met, if it is, codeblock run again, if not it stops
      int counter = 0;

      do {
        counter++;
        System.Console.WriteLine("counter is at {0}", counter);
      } while(counter < 6);

      System.Console.WriteLine("do-while loop completed");
    }

  }

}