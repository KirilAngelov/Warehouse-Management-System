using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{                                        //this is worker in the real project
    public class SuperviserController:EmployeeController 
    {
        //here maybe add a field for the logged supervisor id
        public int superID { get; set; }
        public void UpdateItem(int ID,decimal Price,int Quantity)
        {
           
            
        }
        public void UpdateItem(int ID, decimal Price)
        {
            
        }
        public void UpdateItem(string Name, decimal Price, int Quantity)
        {
            
        }
        public void UpdateItem(string Name, decimal Price)
        {
             
        }

        public void SetPosition(int id)
        {
            
        }
        public void SetPosition(string FirstName,string LastName)
        {
            
        }
        public void SetSalary(int id)
        {
            
        }
        public void SetSalary(string FirstName, string LastName)
        {
           
        }

        public void Fire(int id)
        {
            
        }
        public void Fire(string FirstName,string LastName)
        {
           
        }
        //TODO specify arguments 
        public void Hire(string FirstName, string LastName, int Age, int YearsOfService,
            decimal Salary, string Position)
        {
            
        }
    }
}
