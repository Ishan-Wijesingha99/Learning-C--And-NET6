
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



    // using tryParse
    public static void tryParseFunction() {
      string numberAsString = "128";

      int parsedValue;

      // if we use int.TryParse, it will return a boolean, true if it parsed successfully, false if it couldn't parse it, we store this in a variable
      // out parsedValue - this stores the parsed value in that variable
      bool success = int.TryParse(numberAsString, out parsedValue);

      // tryParse is available for any data type, float.tryParse, string.tryParse etc
    }

  }

}