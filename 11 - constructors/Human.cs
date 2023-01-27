


using System;



namespace UsingClasses {

  // create Human class
  class Human {

    private string firstName;
    private string lastName;
    private string eyeColour;
    private int age;

    public void IntroduceMyself() {
      System.Console.WriteLine("Hello, my name is {0} {1}", firstName, lastName);
    }



    // inside the Human class, you can create a constructor, which is also considered a member
    // needs same name as class itself
    public Human(string firstName, string lastName, string eyeColour, int age) {
      
      // "this" keyword points to the class
      this.firstName = firstName;
      this.lastName = lastName;
      this.eyeColour = eyeColour;
      this.age = age;
    }

  }

}