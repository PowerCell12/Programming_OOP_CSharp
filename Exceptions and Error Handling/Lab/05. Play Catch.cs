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


    List<int> array_int = Console.ReadLine().Split().Select(int.Parse).ToList();
    int count = 0;

    while(count < 3){
      List<string> command = Console.ReadLine().Split().ToList();
  
      try{

        if (command[0] == "Replace"){
          array_int[int.Parse(command[1])] = int.Parse(command[2]);
        } 
        else if (command[0] == "Print"){
          int start = int.Parse(command[1]);
          int end = int.Parse(command[2]);

          if ( end >= array_int.Count || start < 0){
            throw new ArgumentOutOfRangeException();
          }

          for (int i = start; i <= end; i++){
          
            if (i == end){
            Console.Write($"{array_int[i]}\n");
            }
            else{
            Console.Write($"{array_int[i]}, ");
              
            }
          }


        } 
        else if (command[0] == "Show"){
          Console.WriteLine(array_int[int.Parse(command[1])]);
        }      


      }
      catch(ArgumentOutOfRangeException exception){
        Console.WriteLine("The index does not exist!");
        count++;
      }
      catch(FormatException exception){
        Console.WriteLine("The variable is not in the correct format!");
        count++;
      }

    }

    Console.WriteLine(string.Join(", ", array_int));

  
  }
}
