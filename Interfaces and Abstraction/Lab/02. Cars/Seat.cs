namespace Cars;

public class Seat : ICar
{
    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public string Model{get;}

    public string Color {get;}

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }


    public override string ToString()
    {
        return $"{Color} {Model}\n{Start()}\n{Stop()}";
    }

}