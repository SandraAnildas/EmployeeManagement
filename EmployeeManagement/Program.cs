using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace EmployeeManagement
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Management System!");

            while (true)
            {
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear();

                
                Console.WriteLine("a. Employee");
                Console.WriteLine("b. HR");
                Console.WriteLine("c. Exit");
                Console.WriteLine("Please choose an option:");

                string? choice = Console.ReadLine();

                if (choice != null)
                {
                    switch (choice)
                    {
                        case "a":
                            Console.WriteLine("Please enter your Employee No:");
                            int employeeNo = Convert.ToInt32(Console.ReadLine());

                            Employee employee = FindEmployee(employeeNo);

                            if (employee != null)
                            {
                                Console.WriteLine("\nEmployee Menu");
                                Console.WriteLine("a. View My Details");
                                Console.WriteLine("b. Apply for Leave");
                                Console.WriteLine("c. Exit");
                                Console.WriteLine("Please choose an option:");

                                string? empChoice = Console.ReadLine();

                                if (empChoice != null)
                                {
                                    switch (empChoice.ToLower())
                                    {
                                        case "a":
                                            employee.ViewDetails();
                                            break;
                                        case "b":
                                            employee.ApplyForLeave();
                                            break;
                                        case "c":
                                            Environment.Exit(0);
                                            break;
                                        default:
                                            Console.WriteLine("Invalid choice. Please try again.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please try again.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Employee not found. Please try again.");
                            }
                            break;
                        case "b":
                            Console.WriteLine("Enter HRAdmin username:");
                            string? username = Console.ReadLine();

                            Console.WriteLine("Enter HRAdmin password:");
                            string? password = Console.ReadLine();

                            if (username == "HRAdmin" && password == "OrgHR@1234")
                            {
                                Console.WriteLine("\nHR Menu");
                                Console.WriteLine("a. Add New Employee");
                                Console.WriteLine("b. Approve Leaves");
                                Console.WriteLine("c. Apprise Employee");
                                Console.WriteLine("d. Edit Employee");
                                Console.WriteLine("e. View Employee Details by Employee No");
                                Console.WriteLine("Please choose an option:");

                                string? hrChoice = Console.ReadLine();

                                if (hrChoice != null)
                                {
                                    switch (hrChoice.ToLower())
                                    {
                                        case "a":
                                            AddNewEmployee();
                                            break;
                                        case "b":
                                            ApproveLeaves();
                                            break;
                                        case "c":
                                            AppriseEmployee();
                                            break;
                                        case "d":
                                            EditEmployee();
                                            break;
                                        case "e":
                                            ViewEmployeeDetails();
                                            break;
                                        default:
                                            Console.WriteLine("Invalid choice. Please try again.");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please try again.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid credentials. Access denied.");
                            }
                            break;
                        case "c":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }


        static void AddNewEmployee()
        {
            Console.WriteLine("Enter Employee No:");
            int employeeNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            
            Console.WriteLine("a. Manager");
            Console.WriteLine("b. Developer");
            Console.WriteLine("c. Accounts");
            Console.WriteLine("Select Employee Type:");

            string? choice = Console.ReadLine();

            if (choice != null)
            {
                Employee employee;

                switch (choice.ToLower())
                {
                    case "a":
                        employee = new Manager();
                        break;
                    case "b":
                        employee = new Developer();
                        break;
                    case "c":
                        employee = new Accounts();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Employee not added.");
                        return;
                }

                employee.EmployeeNo = employeeNo;
                employee.Name = name;

                employees.Add(employee);

                Console.WriteLine("Employee added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Employee not added.");
            }
        }

        static void ApproveLeaves()
        {
            Console.WriteLine("Enter Employee No:");
            int employeeNo = Convert.ToInt32(Console.ReadLine());

            Employee employee = FindEmployee(employeeNo);

            if (employee != null)
            {
                Console.WriteLine($"Approving leaves for Employee No: {employeeNo}");
                
            }
            else
            {
                Console.WriteLine("Employee not found. Please try again.");
            }
        }

        static void AppriseEmployee()
        {
            Console.WriteLine("Enter Employee No:");
            int employeeNo = Convert.ToInt32(Console.ReadLine());

            Employee employee = FindEmployee(employeeNo);

            if (employee != null)
            {
                Console.WriteLine($"Apprising Employee No: {employeeNo}");
                
            }
            else
            {
                Console.WriteLine("Employee not found. Please try again.");
            }
        }

        static void EditEmployee()
        {
            Console.WriteLine("Enter Employee No:");
            int employeeNo = Convert.ToInt32(Console.ReadLine());

            Employee employee = FindEmployee(employeeNo);

            if (employee != null)
            {
                Console.WriteLine($"Editing details for Employee No: {employeeNo}");
                Console.WriteLine("Enter the new name:");
                string name = Console.ReadLine();
                employees.FirstOrDefault(emp => emp.EmployeeNo == employeeNo).Name = name;
                Console.WriteLine("Successfully edited");
            }
            else
            {
                Console.WriteLine("Employee not found. Please try again.");
            }
        }

        static void ViewEmployeeDetails()
        {
            Console.WriteLine("Enter Employee No:");
            int employeeNo = Convert.ToInt32(Console.ReadLine());

            Employee employee = FindEmployee(employeeNo);

            if (employee != null)
            {
                Console.WriteLine($"Employee Details for Employee No: {employeeNo}");
                employee.ViewDetails();
            }
            else
            {
                Console.WriteLine("Employee not found. Please try again.");
            }
        }

        static Employee FindEmployee(int employeeNo)
        {
            return employees.Find(e => e.EmployeeNo == employeeNo);
        }
    }
}

