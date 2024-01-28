using System;
using System.IO.Compression;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace PersonRobot;




public class StartUp {
  static void Main()
  {
    List<string> all_Ids = new List<string>();
    


    while(true){

      List<string> person_or_robot = Console.ReadLine().Split().ToList();

      if (person_or_robot[0] == "End"){
        break;
      }

      if (person_or_robot.Count == 2){
        all_Ids.Add(person_or_robot[1]);
      }
      else{
        all_Ids.Add(person_or_robot[2]);
      }



    }

    string to_end = Console.ReadLine();
    List<string> right_ones = new List<string>();

    foreach (var id in all_Ids){
      if (id.EndsWith(to_end)){
        right_ones.Add(id);
      }
    }


    foreach(var thing in right_ones){
      Console.WriteLine(thing);
    }


  }
}
