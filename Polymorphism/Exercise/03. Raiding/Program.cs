using System;
using System.IO.Compression;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


namespace Shapes;

public class StartUp {
  static void Main()
  {

    List<BaseHero> all_heroes = new List<BaseHero>();
    int lines = int.Parse(Console.ReadLine());
    int made = 0;

    while(true){

      if(made == lines){break;}

      string name = Console.ReadLine();

      string type = Console.ReadLine();

      if (type == "Druid"){
        Druid druid = new Druid(name);
        if (druid != null){
          all_heroes.Add(druid);
          made += 1;
        }
      }
      else if (type == "Paladin"){
        Paladin paladin = new Paladin(name);
        if (paladin != null){
          all_heroes.Add(paladin);
          made += 1;
        }
      }
      else if (type == "Rogue"){
        Rogue rogue = new Rogue(name);
        if (rogue != null){
          all_heroes.Add(rogue);
          made += 1;
        }
      }
      else if (type == "Warrior"){
        Warrior warrior = new Warrior(name);
        if (warrior != null){
          all_heroes.Add(warrior);
          made += 1;
        }
      }
      else{
        Console.WriteLine("Invalid hero!");
      }
    } 

    int bossHealth = int.Parse(Console.ReadLine());

    int powerHad = 0;

    foreach(var thing in all_heroes){
      Console.WriteLine(thing.CastAbility());
      powerHad += thing.Power;
    }

    if (powerHad >= bossHealth){
      Console.WriteLine("Victory!");
    }
    else{
      Console.WriteLine("Defeat...");
    }


  }
}
