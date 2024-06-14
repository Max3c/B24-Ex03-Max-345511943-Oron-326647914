public class Car : Veichle 
{
    private CarColor m_color;
    private int m_doors;

    // Constructor
    public Car(string i_modelName, string i_licenseNumber, float i_remainingEnergy, List<Wheel> i_wheels, CarColor i_carColor, int i_numDoors) : base(modelName, licenseNumber, remainingEnergy, wheels)
    {
        m_color = carColor;
        m_doors = numDoors;
    }

       
}