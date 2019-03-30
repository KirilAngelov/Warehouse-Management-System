using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS.Data;
using WMS.Data.Models;

namespace WMS.Business
{
    public class EmployeeController
    {
        //Принципно заради това че накрая връщаме празен стринг/null има по един празен ред обаче
        // ние ще ползваме приложението като даваме една команда след друга а не няколко наведнъж и 
        //затова мисля че празният ред няма да пречи толкова.
        public WarehouseDBContext context = new WarehouseDBContext();
        public EmployeeController()
        {

        }
        public string GetId(string FirstName, string LastName)
        {
            var employee = this.context.Employees.Where(x => x.First_Name == FirstName && x.Last_Name == LastName)
               .FirstOrDefault();
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
                
            }
            else
            {
                string id = $"{employee.First_Name} {employee.Last_Name}'s Id is: {employee.Employee_Id}";
                return id;
            }
            return null;
        }
        public Employee GetEmployee(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x=>x.Employee_Id==Id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
            }
            else
            {
                return employee;
            }
            return null;
        }
        public string GetFirstName(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                string firstName = $"Employee with Id equal to {employee.Employee_Id}'s first name is {employee.First_Name}.";
                return firstName;
            }
            return "";
            
        }
        public string GetLastName(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
            }
            else
            {
                string lastName = $"Employee with Id equal to {employee.Employee_Id}'s last name is {employee.Last_Name}.";
                return lastName;
            }
            return "";
        }
        public string GetAge(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
            }
            else
            {
                string age = $"{employee.First_Name} is {employee.Age} years old.";
                return age;
            }
            return "";
        }
        public string YearsOfService(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
            }
            else
            {
                string years = $"{employee.First_Name}'s years of service are: {employee.Years_Of_Service}.";
                return years;
            }
            return "";

        }
        public string Salary(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
            }
            else
            {
                string salary = $"{employee.First_Name}'s salary is: {employee.Salary} lv.";
                return salary;
            }
            return "";
        }
        public string Position(int Id)
        {
            var employee = this.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
            }
            else
            {
                string position = $"{employee.First_Name}'s position is: {employee.Position}.";
                
                return position;
            }
            return "";
        }

        private void AddItem(Item item)
        {
            this.context.Items.Add(item);
            this.context.SaveChanges();
        }
        private void RemoveItem(int id)
        {
            var item = this.context.Items.FirstOrDefault(x => x.Item_Id == id);
            if (item == null)
            {
                Console.WriteLine("Item not found!");
            }
            else
            {
                this.context.Items.Remove(item);
                this.context.SaveChanges();
            }

        }
        private void RemoveItem(string Name)
        {
            var item = this.context.Items.FirstOrDefault(x => x.Name_Of_Item == Name);
            if (item == null)
            {
                Console.WriteLine("Item not found!");
            }
            else
            {
                this.context.Items.Remove(item);
                this.context.SaveChanges();
            }
        }
        private void UpdateItem(int ID, int Quantity)
        {
            var item = this.context.Items.FirstOrDefault(x=>x.Item_Id==ID);
            if (item==null)
            {
                Console.WriteLine("Item not found");
            }
            else
            {
                item.Quantity = Quantity;
            }
        }

        private void UpdateItem(string Name, int Quantity)
        {
            var item = this.context.Items.FirstOrDefault(x => x.Name_Of_Item==Name);
            if (item == null)
            {
                Console.WriteLine("Item not found");
            }
            else
            {
                item.Quantity = Quantity;
            }
        }

    }
}
