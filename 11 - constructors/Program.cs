


using System;



namespace UsingClasses {

  class UsingClasses {
    
    static void Main(string[] args) {
      
      // use constructor to create instances
      Human james = new Human("James", "Cai", "brown", 21);
      Human tommy = new Human("Tommy", "Hamilton", "blue", 21);

      james.IntroduceMyself();
      tommy.IntroduceMyself();
    }

  }

}