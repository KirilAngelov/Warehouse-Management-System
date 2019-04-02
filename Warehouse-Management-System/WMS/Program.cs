using System;
using WMS.Business;
using WMS.Data.Models;

namespace WMS
{
    class Program
    {
        static void Main(string[] args)
        {
     
            SupervisorController employeeController = new SupervisorController();

            
            employeeController.ListEmployees();
        }
    }
}
