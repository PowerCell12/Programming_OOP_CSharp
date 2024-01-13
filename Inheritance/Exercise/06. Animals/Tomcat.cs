namespace Animals;

public class Tomcat: Cat{


    public const string  Tomcatgender = "Male"; 

    public Tomcat(string name, int age): base(name, age, Tomcatgender){
    }

    public override string ProduceSound()
    {
        return "MEOW";
    }

}