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
            string [] employeeName = new string[10];//parallel arrays
            int [] employeeDepartment = new int[10];
            double [] employeeSalary = new double [10];
            double [] employeeHours = new double[10];
            var x = 0;
            var choice = 0;
            bool isLooping = true;//sentinel variable

            while(isLooping != false){//loop to input employees
                Console.WriteLine();//Print inputed employee info
                Console.WriteLine("Name : [{0}]", string.Join(", ", employeeName));
                Console.WriteLine("Depar: [{0}]", string.Join(", ", employeeDepartment));
                Console.WriteLine("Salar: [{0}]", string.Join(", ", employeeSalary));
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
                Console.WriteLine("Enter 0 to continue or 99 to end");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 99){
                    isLooping=false;
                }
                else{
                    x=x+1;
                }
            }
            Console.WriteLine("Name:  [{0}]", string.Join(", ", employeeName));
            Console.WriteLine("Depar: [{0}]", string.Join(", ", employeeDepartment));
            Console.WriteLine("Salar: [{0}]", string.Join(", ", employeeSalary));
            Console.WriteLine("Hours: [{0}]", string.Join(", ", employeeHours));

            double [] departmentPayroll = new double [7];
            for(int i=0;i<departmentPayroll.Length;++i){//loop to iterate through each department
                for(int e=0; e< employeeName.Length;++e){//loop to iterate through each employee to check if they belong into department being iterated
                    if(employeeDepartment[e] == i+1){//if current employee belongs to current department being checked
                        departmentPayroll[i] = departmentPayroll[i] + (employeeHours[e] * employeeSalary[e]);//current employee being checked gets payroll added to department payroll
                    }
                }
            }
            Console.WriteLine("1.Personnel: $"+departmentPayroll[0]);
            Console.WriteLine("2.Marketing: $"+departmentPayroll[1]);
            Console.WriteLine("3.Information Technology: $"+departmentPayroll[2]);
            Console.WriteLine("4.Computer Services: $"+departmentPayroll[3]);
            Console.WriteLine("5.Sales: $"+departmentPayroll[4]);
            Console.WriteLine("6.Legal: $"+departmentPayroll[5]);
            Console.WriteLine("7.Accounting: $"+departmentPayroll[6]);
        
        }
    }
}
