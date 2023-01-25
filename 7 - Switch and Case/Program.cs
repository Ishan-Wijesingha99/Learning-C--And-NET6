
using System;



namespace SwitchStatement {

  class SwithClass {

    static void Main(string[] args) {

      // using switch statement
      int age = 18;

      switch(age) {
        case 15:
          System.Console.WriteLine("Too young to enter club");
          break;
        case 18:
          System.Console.WriteLine("Old enough to enter the club");
          break;
        default:
          // default is executed if none of the cases match
          System.Console.WriteLine("Does not match any of the cases");
          break;
      }

    }

  }

}