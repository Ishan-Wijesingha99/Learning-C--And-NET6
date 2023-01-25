
// if-else statements work exactly the same as in javascript

using System;



namespace IfStatements {

  class ifStatementsClass {

    static void Main(string[] args) {
      int temp = 10;

      if(temp < 10) {
        System.Console.WriteLine("It's pretty cold");
      } else if(temp > 10) {
        System.Console.WriteLine("It's kinda warm");
      } else {
        System.Console.WriteLine("It's 10 degrees celcius");
      }
    }

  }

}