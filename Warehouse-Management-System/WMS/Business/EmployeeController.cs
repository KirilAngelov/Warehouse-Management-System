using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS.Data;
using WMS.Data.Models;

namespace WMS.Business
{
    public class EmployeeController:WorkerController
    {
        public Item GetItem(int id)
        {
            var item = base.context.Items.FirstOrDefault(x => x.Item_Id == id);
            if(!(item==null))
            {
                return item;
            }
            else
            {
                Console.WriteLine("Item not found");
                return null;
            }
        }
        public int? GetItemId(string ItemName)
        {
            var item = base.context.Items.FirstOrDefault(x => x.Name_Of_Item == ItemName);
            if (!(item==null))
            {
                Console.WriteLine();
                Console.WriteLine($"{item.Name_Of_Item} has Id: ");
                return item.Item_Id;
            }
            else
            {
                Console.WriteLine("Item not found!");
                return null;
            }
          

        }
        public Employee GetEmployee(int Id)
        {
            var employee = base.context.Employees.FirstOrDefault(x => x.Employee_Id == Id);
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
        public int? GetEmployeeId(string fname,string lname)
        {
            var employee = this.context.Employees.Where(x => x.First_Name == fname && x.Last_Name == lname)
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
        public void AddItem(Item item)
        {
            this.context.Items.Add(item);
            this.context.SaveChanges();
        }  
        public void RemoveItem(int id)
        {
            var item = base.context.Items.FirstOrDefault(x => x.Item_Id == id);
            if (item == null)
            {
                Console.WriteLine("Item not found!");
            }
            else
            {
                this.context.Items.Remove(item);
                this.context.SaveChanges();
                Console.WriteLine("Done!");
            }

        }  
        public void UpdateItem(int ID, int Quantity)
        {
            var item = this.context.Items.FirstOrDefault(x=>x.Item_Id==ID);
            if (item==null)
            {
                Console.WriteLine("Item not found");
            }
            else
            {
                item.Quantity = Quantity;
                Console.WriteLine("Done");
            }
        }

      

    }
}
