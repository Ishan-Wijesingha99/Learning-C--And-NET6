// See https://aka.ms/new-console-template for more information

// C# is an object-oriented programming language

// first, in the terminal you need to create a C# app, there are so many different types of apps for C#, you can create a web app, a software app that can be run by windows, linux or Mac etc etc. Simplest C# app to create is a console, to do this use the command: dotnet new console
// then to run the code, use the command: dotnet run (this will automatically run Program.cs)

// PascalCase is used for class names and method names, but camelCase is used for variable names



using System;

// here we create a class called HelloWorld
public class HelloWorld {
  
  // here we create a method inside the class 
  public static void Main(string[] args) {
    // Console is itself a built-in class and WriteLine is a built-in method for that class
    Console.WriteLine("Hello, World!");



    // define a string variable
    string userName = "Ishan";

    Console.WriteLine(userName);

    // can use string concatination like JavaScript
    Console.WriteLine("Hello there " + userName);



    // define a whole number
    int hugeNumber = 43562;
    // define a decimal number
    // add f at end for floating value
    float price = 3.99f;

    Console.WriteLine(hugeNumber + price);



    // there is also type coersion to output a string
    Console.WriteLine("result is: " + hugeNumber);



    // redefining a variable
    // just omit the data type
    hugeNumber = 1000;
    Console.WriteLine(hugeNumber);



    // shorthand for changing variable based off original value of variable
    // hugeNumber = hugeNumber + 10;
    hugeNumber += 10;
    // can also use -= , *=, /=

    Console.WriteLine(hugeNumber);
    
  }
}

