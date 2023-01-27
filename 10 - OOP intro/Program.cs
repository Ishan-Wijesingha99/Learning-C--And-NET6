// class - A blueprint for an object, it spits out instances (objects)
// methods are also called member functions
// properties are also called member variables



using System;



// in order to access classes from other files in the same directory, the namespace needs to be the same
namespace UsingClasses {

  class UsingClasses {
    
    static void Main(string[] args) {
      // create instace from Human class
      Human denis = new Human();

      // setting a variable in an instance
      denis.firstName = "Denis";

      // introduce Denis
      denis.IntroduceMyself();
    }

  }

}