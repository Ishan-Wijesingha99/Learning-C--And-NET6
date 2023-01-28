


using System;



namespace Members {

  class Members {

    // setter and getters
    public string FirstName { get; set; }
    public int Age { get; set; }    
    public int Salary { get; set; }


    // constructor
    public Members(string firstName, int age, int salary) {
      FirstName = firstName;
      Age = age;
      Salary = salary;      
    }

    // destructor/finalizer
    // destructor is also a member
    // class can only have one destructor, while a class can have multiple constructors
    // destructor can not be called
    ~Members() {
      // in here you write cleanup statements
      // whenever an instance is closed, deleted, or it runs out of scope, this code is executed

      // don't include a destructor unless you actually have code you want to run, just omit it
      System.Console.WriteLine("Deconstruction of Members instance");
    }

  }

}