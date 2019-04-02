using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WMS.Data.Models;

namespace WMS.Business
{
    public class SupervisorController : WorkerController
    {

        public SupervisorController()
        {
        }
       
       
        public void Hire(string FirstName, string LastName, int Age, int YearsOfService,
            decimal Salary, string Position)
        {
            var newEmployee = new Employee(FirstName, LastName, Age, YearsOfService, Salary, Position);
            base.context.Employees.Add(newEmployee);
            base.context.SaveChanges();
        }
        public void UpdateItemPrice(int ID, decimal Price)
        {
            var item = base.context.Items.FirstOrDefault(x => x.Item_Id == ID);
            if (!(item == null))
            {
                item.Price = Price;
                base.context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"There is no item with id {ID}");
            }
        }
        public void UpdateItemQuantity(int ID, int Quantity)
        {
            var item = base.context.Items.FirstOrDefault(x => x.Item_Id == ID);
            if (!(item == null))
            {
                item.Quantity = Quantity;
                base.context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"There is no item with id {ID}");
            }
        }
        public void SetPosition(int id,string newPosition)
        {
            var employee = base.context.Employees.FirstOrDefault(x => x.Employee_Id == id);
            if (!(employee == null))
            {
                employee.Position = newPosition;
                base.context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"There is no employee with with id {id}");
            }
        }
        public void SetPosition(string FirstName, string LastName, string newPosition)
        {
            var employee = base.context.Employees.Where(x => x.First_Name == FirstName 
            && x.Last_Name == LastName).FirstOrDefault();

            if (!(employee == null))
            {
                employee.Position = newPosition;
                base.context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"There is no employee with names:{FirstName} {LastName}");
            }

        }
        public void SetSalary(int id,decimal newSalary)
        {
            var employee = base.context.Employees.FirstOrDefault(x => x.Employee_Id == id);
            if(!(employee==null))
            {
                employee.Salary = newSalary;
                base.context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"There is no employee with id:{id}");

            }
        }
        public void SetSalary(string FirstName, string LastName,decimal newSalary)
        {
            var employee = base.context.Employees.
                Where(x => x.First_Name == FirstName && x.Last_Name == LastName).FirstOrDefault();
            if(!(employee==null))
            {
                employee.Salary = newSalary;
                base.context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"There is no employee with names {FirstName} {LastName}");
            }
        }
        public int? GetId(string FirstName, string LastName)
        {
            var employee = this.context.Employees.Where(x => x.First_Name == FirstName && x.Last_Name == LastName)
               .FirstOrDefault();
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
                return null;

            }
            else
            {
                return employee.Employee_Id;
            }

        }
        public Employee GetEmployee(int id)
        {
            var employee = base.context.Employees.FirstOrDefault(x => x.Employee_Id == id);
            if (!(employee == null))
            {
                return employee;
            }
            else
            {
                Console.WriteLine("Error 404");
                return null;
            }
        }
        public void Fire(int id)
        {
            Employee employee = base.context.Employees.FirstOrDefault(x => x.Employee_Id == id);
            base.context.Employees.Remove(employee);
            base.context.SaveChanges();
        }
        public void ListEmployees()
        {
            foreach (var employee in base.context.Employees)
            {
                Console.WriteLine($"Name: {employee.First_Name} {employee.Last_Name} Age:{employee.Age} " +
                    $"Experience in years:{employee.Years_Of_Service} Salary: {employee.Salary} Position: {employee.Position}");
            }

        }
       

    }
}
