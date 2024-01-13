using System;
using System.Linq.Expressions;

namespace Animals;


public class StartUp {
  static void Main()
  {


  
    while (true){

      string type = Console.ReadLine();

      if(type == "Beast!"){
        break;
      }

      List<string> info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();



      try{
        if (type == "Dog"){
          Dog dog = new Dog(info[0], int.Parse(info[1]), info[2]);
          Console.WriteLine(type);
          Console.WriteLine(dog);
        }
        else if (type == "Cat"){
          Cat cat = new Cat(info[0], int.Parse(info[1]), info[2]);
          Console.WriteLine(type);
          Console.WriteLine(cat);
        }
        else if (type == "Frog"){
          Frog frog = new Frog(info[0], int.Parse(info[1]), info[2]);
          Console.WriteLine(type);
          Console.WriteLine(frog);
        }
        else if (type == "Kitten"){
          Kitten kitten = new Kitten(info[0], int.Parse(info[1]));
          Console.WriteLine(type);
          Console.WriteLine(kitten);
        }
        else if (type == "Tomcat"){
          Tomcat tomcat = new Tomcat(info[0], int.Parse(info[1]));
          Console.WriteLine(type);
          Console.WriteLine(tomcat);
        }
      }
      catch (Exception ex){
        Console.WriteLine(ex.Message);
      } 



    }




  }
}
