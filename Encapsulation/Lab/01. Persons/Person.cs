namespace PersonsInfo;

public class  Person{


  
  public Person(string firstname, string lastname, int age){
    FirstName = firstname;
    LastName = lastname;
    Age = age;
  }
  

  public string FirstName{get; private set;}

  public string LastName{get; private set;}


  
  public int Age{get; private set;}




  
  public override string ToString(){
    return $"{FirstName} {LastName} is {Age} years old.";
  }



  
}