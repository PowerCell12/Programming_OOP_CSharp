using System;
using System.IO.Compression;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace PersonRobot;




public class StartUp {
  static void Main()
  {
    List<string> all_birthdays = new List<string>();
    


    while(true){

      List<string> inputs = Console.ReadLine().Split().ToList();

      if(inputs[0] == "End"){
        break;
      }

      if (inputs[0] == "Pet"){
        all_birthdays.Add(inputs[2]);
      }
      else if (inputs[0] == "Citizen"){
        all_birthdays.Add(inputs[4]);
      }


  }

  string year = Console.ReadLine();




  foreach(var thing in all_birthdays){
    List<string> final = thing.Split("/").ToList();

    if (final[2] == year){
      Console.WriteLine(thing);
    }

  }
  


  }
}
