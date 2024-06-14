public class Car : Veichle 
{
    private CarColor m_color;
    private int m_doors;

    // Constructor
    public Car(string i_modelName, string i_licenseNumber, float i_remainingEnergy, List<Wheel> i_wheels, CarColor i_carColor, int i_numDoors) : base(modelName, licenseNumber, remainingEnergy, wheels)
    {
        m_color = carColor;
        m_doors = numDoors;

        wheels.add(new Wheel("Michelin", 31, 31));
        wheels.add(new Wheel("Michelin", 31, 31));
        wheels.add(new Wheel("Michelin", 31, 31));
        wheels.add(new Wheel("Michelin", 31, 31));
    }  
}

public class ElectricCar : Car, IElectricVehicle
{
    private float m_RemainingEngineTime;
    private float m_MaxEngineTime;

    public ElectricCar(string modelName, string licenseNumber, float remainingEnergy, List<Wheel> wheels, CarColor carColor, int numDoors, float remainingEngineTime) : base(modelName, licenseNumber, remainingEnergy, wheels, carColor, numDoors)
    {
        m_RemainingEngineTime = remainingEngineTime;
        m_MaxEngineTime = 3.5;
        
    }

    public void Recharge(float hours)
    {
        if (m_RemainingEngineTime + hours <= m_MaxEngineTime)
        {
            m_RemainingEngineTime += hours;
        }
    }
}

public class FuelCar : Car, IFuelVehicle
{
    private FuelType m_FuelType;
    private float m_RemainingFuelLiters;
    private float m_MaxAmountOfFuel;

    public FuelCar(string modelName, string licenseNumber, float remainingEnergy, List<Wheel> wheels, CarColor carColor, int numDoors, float remainingFuelLiters) : base(modelName, licenseNumber, remainingEnergy, wheels, carColor, numDoors)
    {
        m_FuelType = FuelType.Octane95;
        m_RemainingFuelLiters = remainingFuelLiters;
        m_MaxAmountOfFuel = 45;
    }

    public void Refuel(float i_Amount, FuelType i_FuelType)
    {
        if (m_RemainingFuelLiters + i_Amount <= m_MaxAmountOfFuel)
        {
            m_RemainingFuelLiters += i_Amount;
        }
    }
}