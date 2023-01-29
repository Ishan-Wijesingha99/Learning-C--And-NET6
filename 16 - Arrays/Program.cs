﻿
// arrays
// can only be an array of one type, so only integers or only strings etc




using System;



namespace Arrays {

  class UsingArrays {
    static void Main(string[] args) {

      // creating an integer array

      // use this method when you want to create an array but you don't know yet what the entrees will be
      int[] gradesArray = new int[5]; // we have created an array with 5 entrees, but the only way to assign the values of these entrees is by writing gradesArray[0] = 10; gradesArray[1] = 4; and that takes way too long

      // best way
      int[] gradesArray1 = {20, 13, 43, 1};

      // another way
      int[] gradesArray2 = new int[] {20, 13, 43, 1};

      // access length of array
      System.Console.WriteLine(gradesArray1.Length);



      // foreach loop
      int[] numbersArray = {12, 14, 53, 65, 7};   

      // entree is the current iteration's entree in the array
      foreach(int entree in numbersArray) {
        // whatever is in here will be executed for each entree in the array
        // to access the current entree you just use the entree variable
        System.Console.WriteLine(entree);
      }

      // best way to access the index is to create a counter and increase it by 1 at the end of every iteration
      int loopCounter = 0;
      foreach(int entree in numbersArray) {
        
        System.Console.WriteLine("index is {0}, element is {1}", loopCounter, entree);

        loopCounter++;
      }

    }
  }

}
