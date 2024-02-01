using System;
using System.IO.Compression;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace PersonRobot;




public class StartUp {
  static void Main()
  {

    int lines = int.Parse(Console.ReadLine());
    List<Person> all_citizens = new List<Person>();
    List<Rebel> all_rebels = new List<Rebel>();


    for(int i = 0; i < lines; i++){

      List<string> info = Console.ReadLine().Split().ToList();

      
      if (info.Count == 3){
        Rebel rebel = new Rebel(info[0], int.Parse(info[1]), info[2]);
      
        all_rebels.Add(rebel);
      }
      else{
        Person person = new Person(info[0], int.Parse(info[1]), info[2], info[3]);

        all_citizens.Add(person);

      }





    }

    int all_food = 0;

    while(true){

      string name = Console.ReadLine();

      if (name == "End"){
        break;
      }


      foreach(var thing in all_citizens){

        if (thing.Name == name){
          thing.BuyFood();
          all_food += 10;
        }

      }

      foreach(var thing1 in all_rebels){

        if(thing1.Name == name){
          thing1.BuyFood();
          all_food += 5;
        }
      }


    }

    Console.WriteLine(all_food);

  


  }
}
