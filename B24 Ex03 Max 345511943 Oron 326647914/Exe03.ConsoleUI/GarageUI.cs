using Ex03.GarageLogic;

public class Program
{
    private static Garage garage = new Garage();

    public static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Garage Management System");
            Console.WriteLine("1. Insert a new vehicle");
            Console.WriteLine("2. Display vehicle license numbers");
            Console.WriteLine("3. Change vehicle status");
            Console.WriteLine("4. Inflate tires to maximum");
            Console.WriteLine("5. Refuel a vehicle");
            Console.WriteLine("6. Charge a vehicle");
            Console.WriteLine("7. Display vehicle information");
            Console.WriteLine("8. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    InsertNewVehicle();
                    break;
                case "2":
                    DisplayVehicleLicenseNumbers();
                    break;
                case "3":
                    ChangeVehicleStatus();
                    break;
                case "4":
                    InflateTiresToMax();
                    break;
                case "5":
                    RefuelVehicle();
                    break;
                case "6":
                    ChargeVehicle();
                    break;
                case "7":
                    DisplayVehicleInfo();
                    break;
                case "8":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
            if (!exit)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    private static void InsertNewVehicle()
    {
        // Implementation for inserting a new vehicle
        
    }

    private static void DisplayVehicleLicenseNumbers()
    {
        // Implementation for displaying vehicle license numbers
    }

    private static void ChangeVehicleStatus()
    {
        // Implementation for changing vehicle status
    }

    private static void InflateTiresToMax()
    {
        // Implementation for inflating tires to max
    }

    private static void RefuelVehicle()
    {
        // Implementation for refueling a vehicle
    }

    private static void ChargeVehicle()
    {
        // Implementation for charging a vehicle
    }

    private static void DisplayVehicleInfo()
    {
        // Implementation for displaying vehicle information
    }
}
