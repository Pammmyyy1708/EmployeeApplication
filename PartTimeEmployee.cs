using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public string FirstName
        {
            get { return this.first_name; }
            set { this.first_name = value; }
        }
        public string LastName { 
            get { return this.last_name; }
            set { this.last_name = value;}
        }
        public string Department {
            get { return this.department; }
            set { this.department = value; }
        }
        public string JobTitle { 
            get { return this.job_title; }
            set { this.job_title = value; }
        }
        public double BasicSalary {
            get { return this.basic_salary; }
            set { this.basic_salary = value;}
        }

        public PartTimeEmployee(string Fname, string Lname, string dept, string job) {
            this.first_name = Fname;
            this.last_name = Lname;
            this.department = dept;
            this.job_title = job;
        }
        public void computeSalary(double ratePerHour, int hoursWorked) { 
            this.basic_salary = ratePerHour * hoursWorked;
            
        }
        public double getSalary() {
            return this.basic_salary;
        }


    }
}
