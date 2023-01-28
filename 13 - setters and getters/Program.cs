


using System;



namespace SettersAndGetters {

  class SettersAndGetters {
    
    static void Main(string[] args) {
      Box box1 = new Box();
      box1.SetLength(3);
      box1.SetHeight(4);
      box1.SetWidth(5);

      box1.DisplayInfo();
    }

  }

}