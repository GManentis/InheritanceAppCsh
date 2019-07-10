using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    public abstract class CompanyEmployee
    {
        public CompanyEmployee(string name, string salaary, DateTime? date)
        {

            if(int.TryParse(salaary, out int j))
            {
                this.Salary = j;
            }
            else
            {
                Console.WriteLine("The value is invalid.The system will handle it automatically");
                this.Salary = 0;
            }

            this.EmployeeName = name;
            this.StarDate = date;
        }

        protected string employeeName;
        protected int salary;
        protected DateTime? startDate;

        public string EmployeeName
        {
            get
            {
                if (this.employeeName != null)
                {
                    return this.employeeName;
                }
                else
                {
                    return "John Doe";
                }
            }

            set
            {
                value.Replace(" ", "");
                if (value != "")
                {
                    this.employeeName = value;
                }
                else
                {
                    Console.WriteLine("You will be renamed to John Doe");

                }
            }
        }

        public int Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 680 )
                {
                    Console.WriteLine("invalid salary,the salary will be set to minimum wage");
                    this.salary = 680;
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public DateTime? StarDate
        {
            set
            {
                this.startDate = value;
            }

            get
            {
                if (this.startDate == null)
                {
                    DateTime thisDay = DateTime.Today;
                    return thisDay;
                }
                else
                {
                    return this.startDate;
                }
            }
        }

        public virtual void worktime()
        {
            Console.WriteLine("Hi, my name is{0}, my salary is {1} and I ve been working here since{2}", this.EmployeeName, this.Salary, this.StarDate.ToString());
               
        }


    }
}
