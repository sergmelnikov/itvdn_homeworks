using System;
namespace classes_7
{
    public class Employee
    {
        string position;
        int experience;

        public string FirstName { get; }
        public string LastName { get; }
        
        public string Position
        {
            set
            {
                if (value != null)
                {
                    position = value;
                }
                else
                {
                    position = "Unknown position";
                }
            }
            get
            {
                return position;
            }
        }

        public int Experience
        { 
            set
            {
                if (value >= 0)
                {
                    experience = value;
                }
            }
            get
            {
                return experience;
            }
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public double SalaryCalculator()
        {
            switch (position)
            {
                case "junior":
                    if (0 <= experience && experience < 1)
                    {
                        return 100;
                    }
                    else if (1 <= experience && experience < 2)
                    {
                        return 200; 
                    }
                    else if (2 <= experience && experience < 3)
                    {
                        return 300;
                    }
                    else
                    {
                        return 350;
                    }
                case "middle":
                    if (3 <= experience && experience < 4)
                    {
                        return 400;
                    }
                    else if (4 <= experience && experience < 5)
                    {
                        return 500; 
                    }
                    else if (5 <= experience && experience < 6)
                    {
                        return 600;
                    }
                    else
                    {
                        return 650;
                    }
                case "senior":
                    if (6 <= experience && experience < 7)
                    {
                        return 700;
                    }
                    else if (7 <= experience && experience < 8)
                    {
                        return 800; 
                    }
                    else if (8 <= experience && experience < 9)
                    {
                        return 900;
                    }
                    else
                    {
                        return 950;
                    }
                default:
                    Console.WriteLine("Unavailable position argument");
                    return 0;
            }
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Salary: {SalaryCalculator()}, tax: {SalaryCalculator() * 0.13}");
        }
    }
}
