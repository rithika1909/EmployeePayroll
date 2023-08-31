using EmployeePayroll;

[Yesterday 17:50] Riya Susan Reji

using PayrollService;

using System;

using System.Net;

using System.Numerics;

using System.Reflection;

 

namespace EmployeeManagement

{

    class Program

    {

        static void Main(string[] args)

        {

            Payroll employee = new Payroll()

            {

                Name = "Rithika",
                Salary = 30000,
                Start_Date = "07-06-2023",
                Gender = 'F',
                Phone = "9789286965",
                Address = "Chennai",
                Department = "IT",
                Basic_pay = 15000,
                Deductions = 500,
                Taxable_pay = 100,
                Income_tax = 100,
                Net_pay = 1000
            };

            Operation operations = new Operation();

            operations.AddEmployee_payroll(employee);

            //operations.DeleteEmployee_payroll(14);

            operations.GetAllEmployee_payroll();

            //Payroll employee1 = new Payroll()

            //{

            //    Id = 4,

            //    Name = "Rithika",

            //    Salary = 30000,

            //    Start_Date = "07-06-2023",

            //    Gender = 'F',

            //    Phone = "9789286965",

            //    Address = "Chennai",

            //    Department = "IT",

            //    Basic_pay = 15000,

            //    Deductions = 1S00,

            //    Taxable_pay = 100,

            //    Income_tax = 200,

            //    Net_pay = 1000

            //};

            //operations.UpdateEmployee_payroll(employee1);

        }

    }

}
