using System.Runtime.InteropServices;

namespace PersonsInfo;

public class  Person{

  private int age;

  private string firstName;

  private string lastName;

  private decimal salary;

  
  public Person(string firstname, string lastname, int age, decimal salary){
    FirstName = firstname;
    LastName = lastname;
    Age = age;
    Salary = salary;
  }
  

  public string FirstName{get{return firstName;} private set{

    if (value.Length < 3){
      throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
    }

    firstName = value;

  }}

  public string LastName{get{return lastName;} private set{

    if (value.Length < 3){
      throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
    }


    lastName = value;

  }}


  
  public int Age{get{return age;} private set{

    if (value <= 0){
      throw new ArgumentException("Age cannot be zero or a negative integer!");
    }

    age = value;

  }}


  public decimal Salary {get{return salary;} private set{

    if (value < 650){
      throw new ArgumentException("Salary cannot be less than 650 leva!");
    }

    salary = value;

  }}

  
  public override string ToString(){
    return $"{FirstName} {LastName} receives {Salary:f2} leva.";
  }




  public void IncreaseSalary(decimal percentage){


    decimal increase =   Salary * percentage / 100;

    if (Age < 30){
      increase = increase / 2;
      Salary += increase;
    }
    else{
        Salary += increase;
    }

    
    
  }


  
}