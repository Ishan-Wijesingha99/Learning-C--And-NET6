


using System;



namespace Properties {

  class Properties {
    
    static void Main(string[] args) {
      
      Box box1 = new Box(3, 4, 5);
      
      // this is how you set a property using the in-built set and get
      box1.Length = 4;
      // this you get (read) a property using the in-built set and get
      System.Console.WriteLine(box1.Volume);

      System.Console.WriteLine("Box has volume of {0}", box1.Volume);

    }
  }

}