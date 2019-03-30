using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
    public class SuperviserController:EmployeeController//used if you log on as a superviser 
    {
        public void UpdateItem(int ID,decimal Price,int Quantity)
        {
           
             //   updates the items' price and quantity by finding it by id
        }
        public void UpdateItem(int ID, decimal Price)
        {
            //finds item by id and updates price
        }
        public void UpdateItem(string Name, decimal Price, int Quantity)
        {
            //finds id by name and updates price and quantity
        }
        public void UpdateItem(string Name, decimal Price)
        {
            //finds item by name and updates price 
        }

        public void SetPosition(int id)
        {
            //validation if the person is not a superviser
            //finds the person by id
        }
        public void SetPosition(string FirstName,string LastName)
        {
            //validation if the person is not a superviser
            //finds the person by his names
        }
        public void SetSalary(int id)
        {
            //validation if the person is not a superviser
            //finds the person by id
        }
        public void SetSalary(string FirstName, string LastName)
        {
            //validation if the person is not a superviser
            //finds the person by his names
        }

        public void Fire(int id)
        {
            //validates if the person is not a superviser
            //finds the person by his id
        }
        public void Fire(string FirstName,string LastName)
        {
            //validates if the person is not a superviser
            //finds the person by his names
        }
        //TODO specify arguments 
        public void Hire(string FirstName, string LastName, int Age, int YearsOfService,
            decimal Salary, string Position)
        {
            //YearsOfService might not be 0,he may have worked here before or somewhere else
        }
    }
}
