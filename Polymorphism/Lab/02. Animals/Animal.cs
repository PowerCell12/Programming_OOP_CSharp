namespace Animals;


public class Animal{

    private string name;

    private string favouriteFood;

    public Animal(string name, string favouriteFood)
    {
        Name = name;
        Favoritefod = favouriteFood;
    }

    protected string Name{get{return name;} set{name = value;}}
    protected string Favoritefod{get{return favouriteFood;} set{favouriteFood = value;}}


    public virtual string ExplainSelf(){
        return "...";
    }

}