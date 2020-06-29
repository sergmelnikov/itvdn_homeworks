using System;

namespace classes_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee johnSmith = new Employee("John", "Smith");
            johnSmith.Position = "junior";
            johnSmith.Experience = 2;
            johnSmith.ShowEmployeeInfo();
        }
    }
}
