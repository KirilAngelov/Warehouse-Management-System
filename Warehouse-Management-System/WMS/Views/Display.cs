using System;
using System.Collections.Generic;
using System.Text;
using WMS.Business;
using WMS.Data.Models;

namespace WMS.Views
{
   public class Display
    {
        private int EmployeeClose = 14;
        private int SupervisorClose = 19;
        private EmployeeController employeeController;
        private SupervisorController supervisorController;
        public Display()
        {
            employeeController = new EmployeeController();
            supervisorController = new SupervisorController();
            Input();
        }
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 6) + "Warehouse-Management-System" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
        }
        private void ShowEmployeeMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Get FirstName");
            Console.WriteLine("2. Get LastName");
            Console.WriteLine("3. Get Position");
            Console.WriteLine("4. Get Age");
            Console.WriteLine("5. Get Years");
            Console.WriteLine("6. Get Salary");
            Console.WriteLine("7. Get Item");
            Console.WriteLine("8. Get ItemId");
            Console.WriteLine("9. Get Employee");
            Console.WriteLine("10. Get Employee Id");
            Console.WriteLine("11. Add Item");
            Console.WriteLine("12. Remove Item");
            Console.WriteLine("13. Update Item");
            Console.WriteLine("14. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter the number of the operation you want to do.");
        }
        private void ShowSupervisorMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Get FirstName");
            Console.WriteLine("2. Get LastName");
            Console.WriteLine("3. Get Position");
            Console.WriteLine("4. Get Age");
            Console.WriteLine("5. Get Years");
            Console.WriteLine("6. Get Salary");
            Console.WriteLine("7. Hire");
            Console.WriteLine("8. Update Item Price");
            Console.WriteLine("9. Update Item Quantity");
            Console.WriteLine("10. Set Position");
            Console.WriteLine("11. Set Salary");
            Console.WriteLine("12. Get Worker Id");
            Console.WriteLine("13. Get Worker");
            Console.WriteLine("14. Fire");
            Console.WriteLine("15. List All");
            Console.WriteLine("16. Get Client");
            Console.WriteLine("17. Add Client");
            Console.WriteLine("18. Sell");
            Console.WriteLine("19. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter the number of the operation you want to do.");
        }
        private void Input()
        {
            ShowMenu();
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();
            if (password=="employee")
            {
                int operation = -1;
                do
                {
                    ShowEmployeeMenu();
                    
                    operation = int.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case 1:
                            GetFirstName();
                            break;
                        case 2:
                            GetLastName();
                            break;
                        case 3:
                            GetPosition();
                            break;
                        case 4:
                            GetAge();
                            break;
                        case 5:
                            GetYears();
                            break;
                        case 6:
                            GetSalary();
                            break;
                        case 7:
                            GetItem();
                            break;
                        case 8:
                            GetItemId();
                            break;

                        case 9:
                            GetEmployee();
                            break;
                        case 10:
                            GetEmployeeId();
                            break;
                        case 11:
                            AddItem();
                            break;
                            
                        case 12:
                            RemoveItem();
                            break;
                        case 13:
                            UpdateItem();
                            break;
                        default:
                            break;
                    }
                }
                while (operation != EmployeeClose);
            }
            else if (password=="admin")
            {
                int operationSuper = -1;
                do
                {
                    ShowSupervisorMenu();
                    operationSuper = int.Parse(Console.ReadLine());

                    switch (operationSuper)
                    {
                        case 1:
                            GetFirstName();
                            break;
                        case 2:
                            GetLastName();
                            break;
                        case 3:
                            GetPosition();
                            break;
                        case 4:
                            GetAge();
                            break;
                        case 5:
                            GetYears();
                            break;
                        case 6:
                            GetSalary();
                            break;
                        case 7:
                            Hire();
                            break;
                        case 8:
                            UpdateItemPrice();
                            break;
                        case 9:
                            UpdateItemQuantity();
                            break;
                        case 10:
                            SetPosition();
                            break;

                        case 11:
                            SetSalary(); 
                            break;
                        case 12:
                            GetWorkerID();
                            break;
                        case 13:
                            GetWorker();
                            break;
                        case 14:
                            Fire();
                            break;
                        case 15:
                            ListAll();
                            break;
                        case 16:
                            GetClient();
                            break;
                        case 17:
                            AddClient();
                            break;
                        case 18:
                            Sell();
                            break;
                        default:
                            break;
                    }
                } while (operationSuper != SupervisorClose);
            }
            else
            {
                Console.WriteLine("Incorrect password!");
            }
        }

       

        private void Sell()
        {
            Console.WriteLine("Enter the id of the item to sell:");
            int itemID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter id of the client:");
            int clientID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the quantity to sell:");
            int quantity = int.Parse(Console.ReadLine());
            supervisorController.SellItemToClient(itemID, clientID, quantity);
        }

        private void AddClient()
        {
           // Console.WriteLine("Super17");
            Console.WriteLine("Enter First Name of client:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of client:");
            string lastName = Console.ReadLine();
            supervisorController.AddClient(firstName, lastName, 0, "no");
        }
        //done
        private void GetClient()
        {
            // Console.WriteLine("Super16");
            Console.WriteLine("Input the id of the client you want to get:");
            int id = int.Parse(Console.ReadLine());
           string info= supervisorController.GetClient(id);
            Console.WriteLine(info);
        }
        //done
        private void GetWorkerID()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
           object id= supervisorController.GetId(firstName, lastName);
            Console.WriteLine(id);
        }//адхе

        private void ListAll()
        {
         //   Console.WriteLine("Super15");
            supervisorController.ListEmployees();
        }//done

        private void GetWorker()
        {
            Console.WriteLine("Enter the Id of the worker: ");
            int id = int.Parse(Console.ReadLine());
            var emp = supervisorController.GetEmployee(id);
            Console.WriteLine();
            Console.WriteLine($"Id: {emp.Employee_Id}.");
            Console.WriteLine($"First name: {emp.First_Name}.");
            Console.WriteLine($"Last name: {emp.Last_Name}.");
            Console.WriteLine($"Age: {emp.Age}.");
            Console.WriteLine($"Position: {emp.Position}.");
            Console.WriteLine($"Salary: {emp.Salary}lv.");
            Console.WriteLine($"Years: {emp.Years_Of_Service}.");
        }//done

        private void Fire()
        {
            // Console.WriteLine("Super14");
            Console.WriteLine("Enter the id of the person you want to fire:");
            int id = int.Parse(Console.ReadLine());
            supervisorController.Fire(id);
        }
        //supervisor sets salary
        private void SetSalary()
        {
            Console.WriteLine("Enter the Id of the worker: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            supervisorController.SetSalary(id,salary);
        }//done
        //supervisor sets the position of an employee
        private void SetPosition()
        {
            Console.WriteLine("Enter the Id of the worker: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new position: ");
            string position = Console.ReadLine();
            supervisorController.SetPosition(id, position);
        }//done
        //supervisor updates quantity of item
        private void UpdateItemQuantity()
        {
            Console.WriteLine("Enter the Id of the item you want to update: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new quantity: ");
            int price = int.Parse(Console.ReadLine());
            supervisorController.UpdateItemQuantity(id,price);
        }//done
        //supervisor updates price of item
        private void UpdateItemPrice()
        {
            Console.WriteLine("Enter the Id of the item you want to update: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            supervisorController.UpdateItemPrice(id, price);
        }//done
        //supervisor adds new employee
        private void Hire()
        {
            Console.WriteLine("Enter the name of the worker: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the last name of the worker: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter the age of the worker: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter current years of service of the worker: ");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter position: ");
            string position = Console.ReadLine();
            
            supervisorController.Hire(name,lname,age,years,salary,position);
        }//done
        //Method updates quantity if item from employee
        private void UpdateItem()
        {
            Console.WriteLine("Enter the Id of the item you want to update: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity: ");
            int q = int.Parse(Console.ReadLine());
            employeeController.UpdateItem(id, q);
        }//done

        private void RemoveItem()
        {
            Console.WriteLine("Enter the Id of the product you want to remove: ");
            int id = int.Parse(Console.ReadLine());
            employeeController.RemoveItem(id);
        }//done

        private void AddItem()
        {
            Console.WriteLine("Enter item name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter date: ");
            string date = Console.ReadLine();
            Console.WriteLine("Enter price of product: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter expiration date: ");
            string expDate = Console.ReadLine();
            Console.WriteLine("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Id of the employee which stored it: ");
            int id = int.Parse(Console.ReadLine());
            var item = new Item(name,date,price,expDate,quantity,id);
            employeeController.AddItem(item);
            Console.WriteLine("Done!");
        }//done

        private void GetEmployeeId()
        {
            Console.WriteLine("Enter the first name of the worker: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the last name of the worker: ");
            string lname = Console.ReadLine();
            int? id = employeeController.GetEmployeeId(fname, lname);
            Console.WriteLine();
            Console.WriteLine($"{fname} {lname}'s Id is: {id}");

        }//done

        private void GetEmployee()
        {
            Console.WriteLine("Enter Id to search by: ");
            int id = int.Parse(Console.ReadLine());
            var emp = employeeController.GetEmployee(id);
            Console.WriteLine($"First name: {emp.First_Name}");
            Console.WriteLine($"Last name: {emp.Last_Name}");
            Console.WriteLine($"Position: {emp.Position}");
        }//done

        private void GetItemId()
        {
            Console.WriteLine("Enter Item name to search by: ");
           string name = Console.ReadLine();
            int? result = employeeController.GetItemId(name);
            Console.WriteLine(result);
        }//done

        private void GetItem()
        {
            Console.WriteLine("Enter Id to search by: ");
            int id = int.Parse(Console.ReadLine());
            var result = employeeController.GetItem(id);
            Console.WriteLine($"Item name: {result.Name_Of_Item}.");
            Console.WriteLine($"Date added: {result.Date_Added}.");
            Console.WriteLine($"Item price: {result.Price} lv.");
            Console.WriteLine($"Item expiration date: {result.Expiration_Date}.");
            Console.WriteLine($"Quantity: {result.Quantity}.");
            Console.WriteLine($"Stored by worker with Id: {result.Stored_By}");
        }//done

        private void GetSalary()
        {
            Console.WriteLine("Enter Id to search by: ");
            int id = int.Parse(Console.ReadLine());
            string result = employeeController.Salary(id);
            Console.WriteLine(result);
        }//done maybe remove or give to Supervisor

        private void GetYears()
        {
            Console.WriteLine("Enter Id to search by: ");
            int id = int.Parse(Console.ReadLine());
            string result = employeeController.YearsOfService(id);
            Console.WriteLine(result);
        }//done

        private void GetAge()
        {
            Console.WriteLine("Enter Id to search by: ");
            int id = int.Parse(Console.ReadLine());
            string result = employeeController.GetAge(id);
            Console.WriteLine(result);
        }//done

        private void GetPosition()
        {
            Console.WriteLine("Enter Id to search by: ");
            int id = int.Parse(Console.ReadLine());
            string result = employeeController.Position(id);
            Console.WriteLine(result);
        }//done

        private void GetLastName()
        {
            Console.WriteLine("Enter Id to search by: ");
            int id = int.Parse(Console.ReadLine());
            string result = employeeController.GetLastName(id);
            Console.WriteLine(result);
        }//done

        private void GetFirstName()
        {
            Console.WriteLine("Enter id to search by: ");
            int id = int.Parse(Console.ReadLine());
            string result=employeeController.GetFirstName(id);
            Console.WriteLine(result);
            Console.WriteLine();
        }//done
    }
}
