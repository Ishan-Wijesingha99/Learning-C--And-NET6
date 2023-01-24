
using System;



namespace Operators {

  class OperatorClass {

    static void Main(string[] args) {
  
      // unary operators (switches it)
      int num1 = 5;
      System.Console.WriteLine(-num1); // will output -5
      
      bool isSunny = true;
      System.Console.WriteLine(!isSunny); // will output false



      // increment and decrement operators
      int num2 = 0;

      // increase by 1
      num1++; // only takes effect on next line
      ++num1; // takes effect on this line

      // decrease by 1
      num1--; // only takes effect on next line
      --num1; // takes effect on this line



      // remainder operator, it will return the remainder of the division
      int remainder = 11 % 2;
      System.Console.WriteLine(remainder);



      // relational and type operators
      bool isLower = 10 < 3; // false
      bool isHigher = 7 > 4; // true
      bool isHigherOrEqual = 6 >= 6; // true
      bool isLowerOrEqual = 4 <= 1; // true



      // equality operator
      int num3 = 10;
      int num4 = 13;

      // there is no == vs === like in javascript, there is only strict equality
      // can't compare two values of different types
      System.Console.WriteLine(num3 == num4); // false

      // there is also only one unequal operator
      System.Console.WriteLine(num3 != num4); // true

      

      // conditional operators
      bool isLowerAndSunny = isLower && isSunny; // false && true ends up with false

      bool isLowerOrSunny = isLower || isSunny; // false || true ends up with true 
    }

  }

}