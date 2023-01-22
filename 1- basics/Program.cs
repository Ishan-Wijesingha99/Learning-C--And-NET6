// See https://aka.ms/new-console-template for more information

// C# is an object-oriented programming language

// first, in the terminal you need to create a C# app, there are so many different types of apps for C#, you can create a web app, a software app that can be run by windows, linux or Mac etc etc. Simplest C# app to create is a console, to do this use the command: dotnet new console
// then to run the code, use the command: dotnet run (this will automatically run Program.cs)

// PascalCase is used for class names and method names, but camelCase is used for variable names





using System;

// here we create a class called HelloWorld
public class HelloWorld {
  
  // here we create a variable inside the class
  static int classNumber = 1;



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
    


    /*
    multi
    line
    comment
    just
    like
    javascript
    */



    // scope in C# is basically the exact same as in javascript, variables are available down the scope chain, but not across the scope chain from sibling methods/codeblocks, and also not available from up the scope chain
    // just like javascript, C# looks in the current scope for the variable in question, if it can't find it, it goes up one level in the scope chain, if it can't find it there, it keeps going until it finds it



    // implicit vs explicit use of primitive datatypes
    // all the datatypes you've used so far are primitives

    // explicit (you tell C# what data type it is)
    string name = "Ishan";
    char letter = 'e';
    int negativeNumber = -4;
    bool toggle = false;

    // implicit (C# automatically comes up with data type for you)
    var userName2 = "Hugh"; // if you hover over the word var, it will tell you the data type C# decided on

  }
}





// challenge: create a program that swaps two numbers

// 1. create class that contains the method you will create (C# is object-oriented so you'll have too)
public class ChallengeOneApp {
  
  // 2. create method inside class 
  public static void SwapTwoNumbers() {
    // define two numbers
    var a = 5;
    var b = 20;

    // utilise c to swap numbers
    var c = a;

    // make a = 20
    a = b;
    // make b = 5
    b = c;
  }
}