using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS.Data;

namespace WMS.Business
{
   public class WorkerController
    {
        public WarehouseDBContext context = new WarehouseDBContext();
        public WorkerController()
        {

        }
        public string GetFirstName(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Worker not found");
                return null;
            }
            else
            {
                string firstName = $"Worker with Id equal to {employee.Employee_Id}'s first name is {employee.First_Name}.";
                return firstName;
            }


        }  
        public string GetLastName(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Worker not found!");
                return null;
            }
            else
            {
                string lastName = $"Worker with Id equal to {employee.Employee_Id}'s last name is {employee.Last_Name}.";
                return lastName;
            }

        }  
        public string Position(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {

                Console.WriteLine("Worker not found!");
                return "";
            }
            else
            {
                string position = $"{employee.First_Name}'s position is: {employee.Position}.";

                return position;
            }

        }
        public string GetAge(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
                return "";
            }
            else
            {
                string age = $"{employee.First_Name} is {employee.Age} years old.";
                return age;
            }

        }
        public string YearsOfService(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
                return "";
            }
            else
            {
                string years = $"{employee.First_Name}'s years of service are: {employee.Years_Of_Service}.";
                return years;
            }


        }
        public string Salary(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
                return "";
            }
            else
            {
                string salary = $"{employee.First_Name}'s salary is: {employee.Salary} lv.";
                return salary;
            }
        }

    }
}
