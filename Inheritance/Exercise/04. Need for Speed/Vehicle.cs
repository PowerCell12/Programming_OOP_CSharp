using System.ComponentModel;

namespace NeedForSpeed;

public abstract class  Vehicle{

  public Vehicle(int horsePower, double fuel){
    Fuel = fuel;
    HorsePower = horsePower;
  }



  private const double DefaultFuelConsumption = 1.25;

  public virtual double FuelConsumption => DefaultFuelConsumption;


  public double Fuel{get; set;}

  public int HorsePower{get; set;}

  public virtual void Drive(double kilometers){
    double fuelNeeded = kilometers * FuelConsumption;

    Fuel -= fuelNeeded;

  }


}