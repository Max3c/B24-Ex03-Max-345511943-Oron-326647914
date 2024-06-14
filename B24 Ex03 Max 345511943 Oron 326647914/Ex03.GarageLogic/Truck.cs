public class Truck : Vehicle, IFuelVehicle
{
    private bool m_CarryingHazardousMaterials;
    private float m_CargoVolume;
    private FuelType m_FuelType;
    private float m_maxAmountOfFuel;

    public Truck(string modelName, string licenseNumber, float remainingEnergy, List<Wheel> wheels, bool carryingHazardousMaterials, float cargoVolume) : base(modelName, licenseNumber, remainingEnergy, wheels)
    {
        m_CarryingHazardousMaterials = carryingHazardousMaterials;
        m_CargoVolume = cargoVolume;
        m_FuelType = fuelType.soler;
        m_maxAmountOfFuel = 120;

        wheels.add(new Wheel("Michelin", 28, 28));
        wheels.add(new Wheel("Michelin", 28, 28));
        wheels.add(new Wheel("Michelin", 28, 28));
        wheels.add(new Wheel("Michelin", 28, 28));
        wheels.add(new Wheel("Michelin", 28, 28));
        wheels.add(new Wheel("Michelin", 28, 28));
        wheels.add(new Wheel("Michelin", 28, 28));
        wheels.add(new Wheel("Michelin", 28, 28));

    }

    public void Refuel(float i_Amount)
    {
        if (m_RemainingEnergy + i_Amount <= m_TankVolume)
        {
            m_RemainingEnergy += i_Amount;
        }
    }
}