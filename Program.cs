using System;
/**
Name: Andrew Seigworth
Date of completion: 5/1/2020

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MPLS Dog Boarding Payroll");
            string [] employeeName = new string[10];
            int [] employeeDepartment = new int[10];
            double [] employeeSalary = new double [10];
            double [] employeeHours = new double[10];
            var x = 0;
            var choice = 0;

            while(x != 99){
                Console.WriteLine();
                Console.WriteLine("Name: [{0}]", string.Join(", ", employeeName));
                Console.WriteLine("Department: [{0}]", string.Join(", ", employeeDepartment));
                Console.WriteLine("Salary: [{0}]", string.Join(", ", employeeSalary));
                Console.WriteLine("Hours: [{0}]", string.Join(", ", employeeHours));
                Console.WriteLine("Enter employee name");
                employeeName[x] = Console.ReadLine();

                Console.WriteLine("Enter employee department");
                Console.WriteLine("1.Personnel 2.Marketing 3.Information Technology 4.Computer Services 5.Sales 6.Legal 7.Accounting");
                employeeDepartment[x] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter employee salary");
                employeeSalary[x] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter employee hours");
                employeeHours[x] = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter 0 to continue or 1 to end");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1){
                    x=99;
                }
                else{
                    x=x+1;
                }
            }
            Console.WriteLine("Name: [{0}]", string.Join(", ", employeeName));
            Console.WriteLine("Department: [{0}]", string.Join(", ", employeeDepartment));
            Console.WriteLine("Salary: [{0}]", string.Join(", ", employeeSalary));
            Console.WriteLine("Hours: [{0}]", string.Join(", ", employeeHours));
        
        }
    }
}
