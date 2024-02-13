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

    List<string> integers = Console.ReadLine().Split().ToList();
    double sum = 0;


    for (int i =0; i < integers.Count; i++){

      try{

          int final = int.Parse(integers[i]);
          sum += final;

      }
      catch(FormatException){
        Console.WriteLine($"The element '{integers[i]}' is in wrong format!");
      }
      catch(OverflowException){
        Console.WriteLine($"The element '{integers[i]}' is out of range!");
      }
      finally{

        Console.WriteLine($"Element '{integers[i]}' processed - current sum: {sum}");

      }
    }

    Console.WriteLine($"The total sum of all integers is: {sum}");



  
  }
}
