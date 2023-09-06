using EmployeePayroll;

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

            //operations.AddEmployee_payroll(employee);

            //operations.DeleteEmployee_payroll(14);

           // operations.GetAllEmployee_payroll();

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
            //operations.ParticularRange("2023-01-01");
            //operations.SumAvgMinMax();
            List<Payroll> list = new List<Payroll>();
            list.Add(new Payroll()
            {
                Name = "Rithika",
                Salary = 50000,
                Start_Date = "01-05-2000",
                Gender = 'F',
                Phone = "1234567890",
                Address = "Chennai",
                Department = "Finance",
                Basic_pay = 20000,
                Deductions = 500,
                Taxable_pay = 100,
                Income_tax = 1000,
                Net_pay = 35000
            });
            list.Add(new Payroll()
            {
                Name = "Zoya",
                Salary = 60000,
                Start_Date = "01-06-2010",
                Gender = 'F',
                Phone = "1234567890",
                Address = "Chennai",
                Department = "Tech",
                Basic_pay = 11000,
                Deductions = 200,
                Taxable_pay = 100,
                Income_tax = 1500,
                Net_pay = 30000
            });
            operations.UsingWithThread(list);
            operations.UsingWithoutThread(list);

        }

    }

}
