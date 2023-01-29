
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



      System.Console.WriteLine("foreach loop section");
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



      System.Console.WriteLine("multi-dimensional arrays section");
      // 2D arrays
      
      // creating 2D array
      int[,] matrix1 =
      {
        {4, 4, 7}, // row 0
        {6, 5, 6}, // row 1
        {7, 10, 11} // row 2
      };

      // accessing values in 2D array
      // use matrix1[row, index]
      System.Console.WriteLine(matrix1[0,2]); // row 0, index 2
      System.Console.WriteLine(matrix1[1,0]); // row 1, index 0



      // creating 3D array
      int[,,] matrix2 =
      {
        { // depth 0
          {4, 8, 12}, // row 0
          {3, 3, 2}, // row 1
          {9, 10, 7} // row 2
        },
        { // depth 1
          {5, 5, 2}, // row 0
          {9, 9, 6}, // row 1
          {2, 4, 4} // row 2
        }
      };



      System.Console.WriteLine("properties of multi-dimensional arrays");
      // access by using matrix2[depth, row, index]
      System.Console.WriteLine(matrix2[0, 2, 2]); // = 7
      System.Console.WriteLine(matrix2[1, 1, 0]); // = 9

      // access dimensions of an multi-demensional array
      System.Console.WriteLine(matrix1.Rank); // 2
      System.Console.WriteLine(matrix2.Rank); // 3

      // access rows, columns etc
      System.Console.WriteLine(matrix2.GetLength(0)); // this returns the depth which is 2
      System.Console.WriteLine(matrix2.GetLength(1)); // this returns the length which is 3 
      System.Console.WriteLine(matrix2.GetLength(2)); // this returns the width which is 3



      System.Console.WriteLine("foreach loop for multi-dimensional arrays section");
      // looping through multi-dimensional arrays
      // a foreach loop will loop through multi-dimensional arrays with no problem 
      // however, you cannot change the current iteration's entree using foreach loop, you can't say entree = 10;
      foreach (int entree in matrix1) {
        System.Console.WriteLine(entree);
      }



      System.Console.WriteLine("nested forloops section");
      // another way to loop through multi-dimensional arrays that allows for more control is nested for-loop

      // loops through depth
      for(int i=0; i<matrix2.GetLength(0); i++) { 

        // loops through length
        for(int j=0; j<matrix2.GetLength(1); j++) {

          // loops through width
          for(int k=0; k<matrix2.GetLength(2); k++) {

            // this is how you access the current entree
            System.Console.WriteLine(matrix2[i,j,k]);

          }

        }

      }



      System.Console.WriteLine("jagged arrays section");
      // jagged arrays (nested arrays)

      // this will create an array that contains 3 arrays inside of it
      int[][] jaggedArray1 = new int[][]
      {
        new int[] {3, 5, 7, 9},
        new int[] {1, 2, 3},
        new int[] {10, 9}
      };

      // this is how you access those values
      System.Console.WriteLine(jaggedArray1[1][2]); // this will go to the second array, then index 2 of that array = 3
      System.Console.WriteLine(jaggedArray1[0][3]); // this will go to the first array, then index 3 of that array = 9
      System.Console.WriteLine(jaggedArray1[2][1]); // this will go to the third array, then index 1 of that array = 9


    }
  }

}
