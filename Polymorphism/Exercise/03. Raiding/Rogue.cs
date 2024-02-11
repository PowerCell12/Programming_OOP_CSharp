public class Rogue : BaseHero
{

    public Rogue(string name): base(name, 80){

    }


    public override string CastAbility()
    {
        return $"Rogue - {Name} hit for {Power} damage";
    }
}