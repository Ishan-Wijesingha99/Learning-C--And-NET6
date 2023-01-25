
using System;



namespace tryParse {

  class tryParseClass {

    static void Main(string[] args) {
      
      // using tryParse
      string numberAsString = "128";

      int parsedValue;

      // if we use int.TryParse, it will return a boolean, true if it parsed successfully, false if it couldn't parse it, we store this in a variable
      // out parsedValue - this stores the parsed value in that variable
      bool success = int.TryParse(numberAsString, out parsedValue);

      // tryParse is available for any data type, float.tryParse, string.tryParse etc

      parseTemp();
    }

    

    // function that parses temperature that user writes in terminal
    public static void parseTemp() {
      
      System.Console.WriteLine("Please type in a temperature in degrees celsius and we will tell you how to dress");
      string userInput = Console.ReadLine();

      int parsedTemp;

      if(int.TryParse(userInput, out parsedTemp)) {

        if(parsedTemp >= 20) {

          System.Console.WriteLine("It's quite hot, don't wear much");
        
        } else if(parsedTemp < 20 && parsedTemp >= 10) {
        
          System.Console.WriteLine("It's a fair temperature, where shorts and a shirt");
        
        } else if(parsedTemp < 10) {
        
          System.Console.WriteLine("It's cold, where a jacket");
        
        }

      } else {
        System.Console.WriteLine("Please type a valid temperature");
      }

    }

  }

}

