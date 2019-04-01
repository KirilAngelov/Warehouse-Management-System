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
            var item = base.context.Items.FirstOrDefault(x=>x.Item_Id==Id);
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
        /*
        public void UpdateItem(int ID, decimal Price)
        public void UpdateItem(string Name, decimal Price, int Quantity)
        public void UpdateItem(string Name, decimal Price)
        public void SetPosition(int id)
        public void SetPosition(string FirstName,string LastName)
        public void SetSalary(int id)
        public void SetSalary(string FirstName, string LastName)
        public void Fire(int id)
        public void Fire(string FirstName,string LastName)*/


    }
}
