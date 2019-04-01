using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WMS.Data.Models;

namespace WMS.Business
{
    public class SupervisorController : EmployeeController
    {

        public SupervisorController()
        {
        }
        //Принципно съм съгласен да намалим броя на overload-ите на UpdateItem.
        public void UpdateItem(int Id, decimal Price, int Quantity)
        {
            var item = base.context.Items.FirstOrDefault(x => x.Item_Id == Id);
            item.Price = Price;
            item.Quantity = Quantity;
            base.context.SaveChanges();
        }
        //To be continued...
        public void Hire(string FirstName, string LastName, int Age, int YearsOfService,
            decimal Salary, string Position)
        {
            var newEmployee = new Employee(FirstName, LastName, Age, YearsOfService, Salary, Position);
            base.context.Employees.Add(newEmployee);
            base.context.SaveChanges();
        }
        //Methods that are currently undone and need discussing:
        //Dzivev below

        //test
        public void UpdateItem(int ID, decimal Price)
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
        //test
        public void UpdateItem(string Name, decimal Price, int Quantity)
        {
            var item = base.context.Items.FirstOrDefault(x => x.Name_Of_Item == Name);
            if (!(item == null))
            {
                item.Price = Price;
                item.Quantity = Quantity;
                base.context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"There is no item with name {Name}");
            }
        }
        //test
        public void UpdateItem(string Name, decimal Price)
        {
            var item = base.context.Items.FirstOrDefault(x => x.Name_Of_Item == Name);
            if (!(item == null))
            { 
            item.Price = Price;
            base.context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"There is no item with name {Name}");
            }
        }
        //test
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
        //test
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
        //test
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
        /*
        //needs discussing
        //public void Fire(int id)
        //public void Fire(string FirstName,string LastName)
        */

    }
}
