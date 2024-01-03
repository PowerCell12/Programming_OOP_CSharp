public class Child : Person
{
    public Child(string name1, int age1) : base(name1, age1)
    {
    }

    public override int Age{get{return base.Age;} set{ if(value <= 15){base.Age=value;}}}

  
}