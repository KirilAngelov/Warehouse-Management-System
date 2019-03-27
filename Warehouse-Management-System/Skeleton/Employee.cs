using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
   public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int YearsOfService { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }


        public Employee(int Id,string FirstName,string LastName,int Age,int YearsOfService,
            decimal Salary,string Position)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.YearsOfService = YearsOfService;
            this.Salary = Salary;
            this.Position = Position;
        }
    }
}
