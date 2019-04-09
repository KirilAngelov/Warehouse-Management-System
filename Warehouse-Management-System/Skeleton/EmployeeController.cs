using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
   public class EmployeeController
    {
        //here maybe add a field for the logged supervisor id
        public int employeeID { get; set; }
        public EmployeeController()
        {

        }
     
        public int GetId(string FirstName,string LastName)
        {
            return 0;
        }
        public string GetFirstName(int ID)
        {
            return null;
        }
        public string GetLastName(int ID)
        {
            return null;
        }
        public int GetAge(int ID)
        {
            return 0;
        }
        public int YearsOfService(int ID)
        {
            return 0;
        }
        public decimal Salary(int ID)
        {
            return 0;
        }
        public string Position(int ID)
        {

            return null;
        }


        private void AddItem(Items item)
        {
            
        }
        private void RemoveItem(int id)
        {

        }
        private void RemoveItem(string Name)
        {

        }

      
        private void UpdateItem(int ID,int Quantity)
        {
            //updates the quantity of an item by given id 
        }
      
        private void UpdateItem(string Name,int Quantity)
        {
            //updates the quantity of the item by given name
        }
    }
}
