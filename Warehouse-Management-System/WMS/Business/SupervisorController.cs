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
                Console.WriteLine($"Name: {employee.First_Name} {employee.Last_Name}");
                Console.WriteLine($"Age:{employee.Age} ");
                Console.WriteLine($"Experience in years:{employee.Years_Of_Service}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine();
            }

        }
        public void ListAllItems()
        {
            foreach (var item in context.Items)
            {
                Console.WriteLine($"Name: {item.Name_Of_Item}");
                Console.WriteLine($"Date added: {item.Date_Added}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine($"Expiration date: {item.Expiration_Date}");
                Console.WriteLine($"The item is stored by " +
                    $"{this.context.Employees.FirstOrDefault(x=>x.Employee_Id==item.Item_Id).First_Name}"+" "+
                    $"{this.context.Employees.FirstOrDefault(x => x.Employee_Id == item.Item_Id).Last_Name}");
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
               $"Spent_Money:{client.Spent_Money} Status: {client.Is_VIP}";
                return info;
            }
        }
        public void AddClient(string FirstName,string LastName,decimal Spent_Money,string Is_Vip)
        {
            var client = new Client(FirstName,LastName,Spent_Money,Is_Vip);
            base.context.Clients.Add(client);
            base.context.SaveChanges();
        }
        public object SellItemToClient(int itemId,int clientId,int ItemQuantity)
        {
            var item = base.context.Items.FirstOrDefault(x => x.Item_Id == itemId);
            var client = base.context.Clients.FirstOrDefault(x => x.Client_Id == clientId);
            decimal priceToPay = item.Price * ItemQuantity;
            if (item.Quantity<ItemQuantity)
            {
                Console.WriteLine("There isn't as much quantity as you are asking!");
                return null;
            }
            if (client.Spent_Money >= 30000)
            {
                client.Is_VIP = "yes";
            }
            if (client.Is_VIP=="yes")
            {
                priceToPay -= priceToPay * 10 / 100;
            }
            client.Spent_Money += priceToPay;
            item.Quantity -= ItemQuantity;
            base.context.SaveChanges();
            Console.WriteLine("Done!");
            return null;

        }
       

    }
}
