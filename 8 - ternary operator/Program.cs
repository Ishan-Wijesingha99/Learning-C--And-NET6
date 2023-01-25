
using System;



namespace TernaryOperator {

  class TernaryOperatorClass {

    static void Main(string[] args) {
      
      // ternary operators works exactly the same as in javascript
      bool ateFood = true;

      // ternary operators can only be used to store something as a variable
      string printedString = ateFood ? "He ate food!" : "He did not eat food";

      System.Console.WriteLine(printedString);

      // you can chain ternary operators in C#
      bool drankWater = false;
      string finalString = drankWater ? "He drank water" : (ateFood ? "He ate food but did not drink water" : "He did not eat food or drink water");

      System.Console.WriteLine(finalString);
    }

  }

}