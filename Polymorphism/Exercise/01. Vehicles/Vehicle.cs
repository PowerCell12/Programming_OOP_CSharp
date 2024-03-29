public abstract class Vehicle: IVehicle{
    protected Vehicle(double fuelQuantity, double fuelConsumption)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public double FuelQuantity {get; set;}

    public double FuelConsumption {get; set;} // liters for kilometer



    public abstract void Drive(double kilometers);

    public abstract void Refuel(double kilograms);
}