namespace Animals;

public class Kitten: Cat{


    public const string  Kittengender = "Female"; 

    public Kitten(string name, int age): base(name, age, Kittengender){
    }

    public override string ProduceSound()
    {
        return "Meow";
    }

}