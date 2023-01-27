// you create classes in their own seperate file



using System;



// in order to access classes from other files in the same directory, the namespace needs to be the same
namespace UsingClasses {

  // create Human class
  class Human {
    
    // member variable
    // if you don't add public to your member variables, they can't be accessed
    public string firstName;

    // member variable
    // set it to private so no one can change it
    private string species = "Homo Sapien";

    // member method
    public void IntroduceMyself() {
      System.Console.WriteLine("Hi, I'm {0}", firstName);
    }
  }

}