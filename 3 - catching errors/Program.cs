
using System;



namespace TryAndCatchError {

  class TryAndCatchClass {

    static void Main(string[] args) {
      // let's add two numbers that the user types into the terminal
      Console.WriteLine("Please enter first number");
      string num1String = Console.ReadLine();
      Console.WriteLine("Please enter second number");
      string num2String = Console.ReadLine();

      // we handle possible errors by using a try-catch block
      try
      {
        // here we will try and parse num1String and num2String
        int num1 = int.Parse(num1String);
        int num2 = int.Parse(num2String);

        // log result to the console
        Console.WriteLine(num1 + num2); 

      } catch (FormatException) {

        Console.WriteLine("Format exception, make sure you type an integer");
      
      } catch (OverflowException) {
      
        Console.WriteLine("Overflow exception, make sure the number you type is not too long or too short");
      
      } catch (Exception) {
      
        // Exception accounts for all exceptions (errors), but if you only want to catch a particular type of error, you can use FormatException or OverflowException etc
        // you can create multiple catch blocks for each different type of exception, but if you do this, the Exception catch block must come last

        Console.WriteLine("General exception");

        // if you just write throw, it will come up with the specific error in the terminal
        // throw 
      } finally {
        // whatever is in the finally codeblock will be executed when the try and catch are done, regardless of where the execution stopped
      }
    }

  }

}