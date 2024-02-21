Console.WriteLine("*********** Electricity and Water Bill Calculation Program ***********");

void CalculateWaterBill()
{
    Console.WriteLine("Please enter the customer's full name: ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Please choose customer type");
    Console.WriteLine("Enter 1 if you are a household customer");
    Console.WriteLine("Enter 2 if you are a administrative office customer");
    Console.WriteLine("Enter 3 if you are a manufacturing unit customer");
    Console.WriteLine("Enter 4 if you are a business service customer");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        // Household customer
        // Request input for the number of family members
        Console.WriteLine("Enter the number of family members");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember > 1)
        {
            Console.WriteLine("Enter the water meter reading from the previous month");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the water meter reading for the current month");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberCurrentMonth >= waterNumberLastMonth)
            {
                int waterConsumption = waterNumberCurrentMonth - waterNumberLastMonth;
                double waterConsumptionPerPerson = waterConsumption / numberMember;
                double money = 0;
                if (waterConsumptionPerPerson > 0 && waterConsumption <= 10)
                {
                    money = waterConsumption * 5973 * 1.1;
                }
                else if (waterConsumptionPerPerson > 10 && waterConsumption <= 20)
                {
                    money = waterConsumption * 7051 * 1.1;
                }
                else if (waterConsumptionPerPerson > 20 && waterConsumptionPerPerson <= 30)
                {
                    money = waterConsumption * 8699 * 1.1;
                }
                else
                {
                    money = waterConsumption * 15929 * 1.1;
                }
                Console.WriteLine("The water bill for your family is:{0}", money);
            }
            else
            {
                Console.WriteLine("The water consumption from the previous month is not greater than the current month");
            }
        }
        else
        {
            Console.WriteLine("You are not a household customer");
        }
    }
    else if (typeCustomer == 2)
    {
        // Administrative office customer
        Console.WriteLine("Please enter the water meter reading from the previous month");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the water meter reading for the current month");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
            Console.WriteLine("The water bill for the administrative office is {0}", m);
        }
        else
        {
            Console.WriteLine("The water meter reading from the previous month is not greater than the current month");
        }
    }
    else if (typeCustomer == 3)
    {
        // Manufacturing unit customer
        Console.WriteLine("Please enter the water meter reading from the previous month");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the water meter reading for the current month");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double n = (waterCurrentMonth - waterLastMonth) * 11615 * 1.1;
            Console.WriteLine("The water bill for the manufacturing unit is {0}", n);
        }
        else
        {
            Console.WriteLine("The water meter reading from the previous month is not greater than the current month");
        }
    }
    else if (typeCustomer == 4)
    {
        // Business service customer
        Console.WriteLine("Please enter the water meter reading from the previous month");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the water meter reading for the current month");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double a = (waterCurrentMonth - waterLastMonth) * 11615 * 1.1;
            Console.WriteLine("The water bill for the business service unit is {0}", a);
        }
        else
        {
            Console.WriteLine("The water meter reading from the previous month is not greater than the current month");
        }

    }
    else
    {
        Console.WriteLine("Please enter the correct customer type");
    }
}
