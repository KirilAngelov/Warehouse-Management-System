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
                Console.WriteLine("Done!");
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
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine($"There is no employee with with id {id}.");
            }
        }
        public void SetSalary(int id,decimal newSalary)
        {
            var employee = base.context.Employees.FirstOrDefault(x => x.Employee_Id == id);
            if(!(employee==null))
            {
                employee.Salary = newSalary;
                base.context.SaveChanges();
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine($"There is no employee with id:{id}.");

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
                Console.WriteLine("Employee not found!");
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
        public string GetClient(int id)
        {
            var client = base.context.Clients.FirstOrDefault(x=>x.Client_Id==id);
            if (client == null)
            {
                Console.WriteLine("Client not found");
                return null;
            }
            else
            {
                string info = $"Client Id: {client.Client_Id} Name: {client.First_Name} {client.Last_Name} " +
               $"Status: {client.Is_VIP}";
                return info;
            }
        }
        public void AddClient(string FirstName,string LastName,decimal Spent_Money,string Is_Vip)
        {
            var client = new Client(FirstName,LastName,Spent_Money,Is_Vip);
            base.context.Clients.Add(client);
            base.context.SaveChanges();
        }
        public void SellItemToClient(int itemId,int clientId,int ItemQuantity)
        {
            var item = base.context.Items.FirstOrDefault(x => x.Item_Id == itemId);
            var client = base.context.Clients.FirstOrDefault(x => x.Client_Id == clientId);
            if (client.Spent_Money>=30000)
            {
                client.Is_VIP = "yes";
                item.Price = item.Price - ((15 * item.Price)/100);
               
            }
            client.Spent_Money += item.Price * ItemQuantity;
            base.context.Items.Remove(item);
            base.context.SaveChanges();


        }
       

    }
}
