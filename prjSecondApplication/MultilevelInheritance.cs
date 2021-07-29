using System;
using System.Collections.Generic;
using System.Text;

namespace prjSecondApplication
{   
    
    enum Feedback
    {
        Poor=1,Fair,Good=4,Excellent
    };

    //Base class or parent class
    class Department
    {
        //protected access specifier is usednwith in the class and only in derived class
        protected int Did { get; set; }
        protected string Dname { get; set; }
        protected string City { get; set; }

        internal Department(int Did,string Dname,string City)
        {
            Console.WriteLine("Department Constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.City = City;
        }

        protected internal void DisplayDepartmentinfo()
        {
            Console.WriteLine("Did:{0},Dname:{1}", Did, Dname);
        }
        ~Department()
        {
            Console.WriteLine("Department destructor");
        }

    }
    
    //Single Inheritance
    //Child or derived class Employee
    class Employee :Department
    {
        internal static string CompanyName = "LTI";
        internal int Eid { get; set; }
        internal string Name { get; set; }
        internal string City = "Pune";

        internal Employee(int Eid,string Name,int Did,string Dname,string City) : base(Did, Dname, City)
        {
            Console.WriteLine("Employee Constructor");
            this.Eid = Eid;
            this.Name = Name;
        }

        internal void DisplayEmployeeInfo()
        {
            DisplayDepartmentinfo();
            Console.WriteLine("Department City is :{0}", base.City);
            Console.WriteLine("Eid:{0}, || Ename:{1} || Feedback:{2}", Eid, Name, (int)Feedback.Excellent);
            Console.WriteLine("Employee City is :{0}", City);

        }

        ~Employee()
        {
            Console.WriteLine("Employee destructor");
        }
    }

    class PartTimeEmployee : Employee
    {
        internal int hoursofwork { get; set; }
        internal int salary { get; set; }

        internal PartTimeEmployee(int Eid, string Name, int Did, string Dname, string City,int hoursofwork,int salary):base(Eid,Name,Did, Dname, City)
        {
            this.hoursofwork = hoursofwork;
            this.salary = salary;
        }

        internal int MonthlySalary()
        {
            int Payment = hoursofwork * 30 * salary;
            return Payment;
        }

        ~PartTimeEmployee()
        {
            Console.WriteLine("PartTimeEmployee destructor");
        }

    }
    class MultilevelInheritance
    {
        static void Main()
        {
            //single Inheritance
           /* Employee employee = new Employee(1001, "SAI", 101, "HR", "Madurai");
            employee.DisplayEmployeeInfo();
            employee.DisplayDepartmentinfo();

            //employee.DisplayDepartmentinfo(); //error : since Protected */

            PartTimeEmployee pt = new PartTimeEmployee(1001, "SAI", 101, "HR", "Madurai", 67, 200);
            pt.DisplayEmployeeInfo();
            Console.WriteLine("Monthly Salary:{0}", pt.MonthlySalary());

            GC.Collect();
        }

    }
}
