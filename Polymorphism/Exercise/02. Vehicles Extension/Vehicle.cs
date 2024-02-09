public abstract class Vehicle: IVehicle{


    private double fuelquantity;

    protected Vehicle(double fuelQuantity, double fuelConsumption, double tankcapacity)
    {
        FuelConsumption = fuelConsumption;
        TankCapacity = tankcapacity;
        FuelQuantity = fuelQuantity;

    }

    public double FuelQuantity {get{return fuelquantity;} set{

        if (value > TankCapacity){
            fuelquantity = 0;
        }
        else{
            fuelquantity = value;
        }

    }}

    public double FuelConsumption {get; set;} // liters for kilometer

    public double TankCapacity{get; set;}

    public abstract void Drive(double kilometers);

    public abstract void Refuel(double kilograms);
}