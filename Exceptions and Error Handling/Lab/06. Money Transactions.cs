using System;
using System.IO.Compression;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


namespace Shapes;

public class StartUp {
  static void Main()
  {


    List<string> bank_accs = Console.ReadLine().Split(",").ToList();
    Dictionary<int, double> final = new Dictionary<int, double>();

    foreach(var thing in bank_accs){

      List<string> account = thing.Split("-").ToList();

      final.Add(int.Parse(account[0]), double.Parse(account[1]));

    }


    while(true){

      List<string> command = Console.ReadLine().Split().ToList();

      try{
        if(command[0] == "End"){
          Environment.Exit(0);;
        }

        if (command[0] == "Deposit"){
          final[int.Parse(command[1])] += double.Parse(command[2]);
          double final1 = final[int.Parse(command[1])];
          Console.WriteLine($"Account {command[1]} has new balance: {final1:F2}");
        }
        else if (command[0] == "Withdraw"){
          if (final[int.Parse(command[1])] >= double.Parse(command[2])){
            final[int.Parse(command[1])] -= double.Parse(command[2]);
            double final1 = final[int.Parse(command[1])];
            Console.WriteLine($"Account {command[1]} has new balance: {final1:F2}");
          }
          else{
            Console.WriteLine("Insufficient balance!");
          }
        }
        else{
          Console.WriteLine("Invalid command!");
        }
      }
      catch(KeyNotFoundException){
        Console.WriteLine("Invalid account!");
      }
      finally{
        Console.WriteLine("Enter another command");
      }

    }



  }
}
