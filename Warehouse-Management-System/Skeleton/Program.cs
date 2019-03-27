using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {


            //Methods in the EmployeeController class will be sealed so that BossController doesns't 
            //inherent them
            Console.WriteLine("Hello World!");
            SuperviserController superviser = new SuperviserController();
            
        }
    }
}
