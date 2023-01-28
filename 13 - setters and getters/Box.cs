// setters and getters


using System;



namespace SettersAndGetters {

  class Box {

    // member variables
    // setting these to private doesn't just prohibit you from changing their values, you can't even read their values
    private int length;
    private int height;
    private int width;
    private int volume;

    // you can however create methods that can change private variables
    // as long as the method is public

    // these are setters (they set the value)
    public void SetLength(int length) {
      this.length = length;
    }

    public void SetHeight(int height) {
      this.height = height;
    }

    public void SetWidth(int width) {
      this.width = width;
    }

    // these are getters (they read the value)
    public void getLength(int length) {
      return this.length;
    }

    public void getHeight(int height) {
      return this.height;
    }

    public void getWidth(int width) {
      return this.width;
    }



    // member function
    public void DisplayInfo() {
      System.Console.WriteLine(
        "Length is {0} and height is {1} and width is {2}, so the volume has to be {3}", length, height, width, volume = length*height*width
      );
    }
  }

}