// class properties

// Encapsulation - restricting access to variables in a class (making them private)



using System;



class Box {

  private int length;

  // constructor
  public Box(int length, int height, int width) {
    // can do this.length = length; this.height = height; this.width = width;
    // but can also do it easily this way now
    // you can only use this.length if you've defined length as a member variable, like private int length;
    Length = length;
    Height = height;
    Width = width;
  }



  // easier way to use setters and getters
  // it has to be the capitalized version of the member variable
  public int Length {
    get {
      return length;
    } set {
      // value will be whatever is after the = sign
      length = value;
    }
  }

  // do the above way if you want to introduce extra code or some if-else statements, if you just want to do the regular return length and length = value, then you can do it even faster by doing the following...
  // if you do it this way you don't have to define member variables like "private int Length;"
  public int Height { get; set; }
  public int Width { get; set; }
    
  

  // as for the volume, it doesn't make sense to set the volume because it's based of the length, height, and width, but you should be able to get it
  // can do this way
  public int Volume {
    get {
      return this.length * Height * Width; 
    }
  }
}


