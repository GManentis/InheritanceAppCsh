using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int position;
            DateTime startDate;

            Console.WriteLine("Insert your Name");
            string name = Console.ReadLine();

            Console.WriteLine("Insert your salary");
            string sal = Console.ReadLine();

            Console.WriteLine("Insert date since you got the job");
            string strDate = Console.ReadLine();

            if (DateTime.TryParse(strDate, out DateTime dateValue))
            {
               startDate = dateValue;
            }
            else
            {
                Console.WriteLine("Current date will be set!");
                startDate = DateTime.Today;
            }

            Console.WriteLine("Select your position. 1.Hr Department, 2.Front End Developer or 3.Back End Developer");
            string pos = Console.ReadLine();

            if(int.TryParse(pos, out int x))
            {
                position = x;
               
            }
            else
            {
                Console.WriteLine("Process will be terminated");
                throw new NotImplementedException("Invalid positon has been inserted!Process will be killed");
            }

            
            switch(position)
            {
                case 1:
                    HrEmployee employeee = new HrEmployee(name,sal,startDate);
                    employeee.worktime();
                    Console.ReadLine();

                    break;
                case 2:
                    Developer devEmployee = new Developer(name, sal, startDate, "Front End Developer");
                    devEmployee.worktime();
                    Console.ReadLine();
                    break;
                case 3:
                    Developer devEmployee2 = new Developer(name, sal, startDate, "Back End Developer");
                    devEmployee2.worktime();
                    Console.ReadLine();
                    break;
                default:
                    throw new NotImplementedException("Invalid positon has been inserted!Process will be killed");
                    
            }

        }
               
    }

}
        

