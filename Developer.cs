using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Developer: CompanyEmployee
    {
        public Developer(string name, string salary, DateTime? date, string Special ) : base(name, salary, date)
        {
            this.Speciality = Special;
        }

        private string speciality;

        public string Speciality
        {
            get
            {
                return speciality;
            }

            set
            {
                if(value == "Front End Developer" || value == "Back End Developer" )
                {
                    this.speciality = value;
                }
                else
                {
                    Console.WriteLine("You shall be considered Full Stack");
                    this.speciality = "Full Stack";
                }
            }
        }

        public string ProgLang
        {
            get
            {
                if(this.Speciality == "Front End Developer")
                {
                    return "Js";
                }
                else if(this.Speciality == "Back End Developer")
                {
                    return "C#";
                }
                else
                {
                    return "N/a";
                }
            }

          
        }

            public override void worktime()
            {
                Console.WriteLine("Hi, my name is {0}, my salary is {1} and I ve been working here since {2} as a  {3}. My favourite programming language is {4}", this.EmployeeName, this.Salary, this.StarDate.ToString(), this.Speciality, this.ProgLang);
            }

    }


}
