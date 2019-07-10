using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class HrEmployee : CompanyEmployee
    {
        public HrEmployee(string name, string salary, DateTime? date) : base(name, salary, date)
        {

        }

        private string speciality = "Hr Department";
        public string Speciality
        {
            get
            {
                return this.speciality;
            }
        }

        public override void worktime()
        {
            Console.WriteLine("Hi, my name is {0}, my salary is {1} and I ve been working here since {2} as a member of {3}", this.EmployeeName, this.Salary, this.StarDate.ToString(),this.speciality);
        }
    }

    
}
