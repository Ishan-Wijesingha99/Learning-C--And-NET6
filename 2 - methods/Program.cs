
// the syntax for a method is...
// AccessSpecifier ReturnType MethodName(parameters)

// Access Specifier - indicates if other classes can use that method or not
// EG - public means yes other classes can use that method, private means no they can't

// Return type - a method can return a value (doesn't have too), the return type is the data type of the returned value, if method doesn't return a value then write void

// Method name - just the name of the method

// parameters - the inputs for a method

// EG -
//  public int Add(int num1, int num2) {
//    return (num1 + num2);
//  }



using System;

namespace MethodPractise {
  
  class MethodClass {

    // Main() is called automatically when the Program.cs file is run and the the MethodClass is created

    // string[] is an array of strings 
    static void Main(string[] args) {
      // in order to use other methods inside this codeblock, we need to add static to those methods

      WriteSomething();

      WriteSpecific("Hellooo Son");

      Console.WriteLine(Add(3, 10));
      Console.WriteLine(Multiply(2, 7));
      Console.WriteLine(Divide(20, 4));

      ReadUserInput();

      Console.WriteLine(AddInTerminal());
    }



    // add static to the WriteSomething() method so it can be called inside of Main()
    public static void WriteSomething() {
      Console.WriteLine("I am called from a method");
    }

    // add static to the WriteSpecific() method so it can be called inside of Main()
    public static void WriteSpecific(string text) {
      Console.WriteLine(text);
    }



    // methods that return a value
    public static int Add(int num1, int num2) {
      return num1 + num2;
    }

    public static int Multiply(int num1, int num2) {
      return num1 * num2;
    }

    public static double Divide(double num1, double num2) {
      return num1 / num2;
    }



    // creating a method that uses user input from the command line
    public static void ReadUserInput() {
      // this line stores what is written in the command prompt as a variable
      string input = Console.ReadLine();
      // this line prints it to the console
      Console.WriteLine(input);
    }

    // add two numbers the user types into the terminal
    public static int AddInTerminal() {
      Console.WriteLine("Please write the first number");
      string num1String = Console.ReadLine();

      Console.WriteLine("Please write the second number");
      string num2String = Console.ReadLine();

      // the two numbers are stored as strings, so we need to convert them to numbers
      int num1 = int.Parse(num1String);
      int num2 = int.Parse(num2String);

      return num1 + num2;
    }
  }

}