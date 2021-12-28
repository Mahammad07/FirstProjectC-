
using department.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace department.Models
{
    class employee
    {
        public int Count { get; set; } 
        public string No { get; set; }

        public string Fullname { get; set; }

        public string Position { get; set; }

        public int Salary { get; set; }

        public string DepartmentName { get; set; }

        public DepartmentName departmentname{ get; set; }



        public employee(string fullname, string position,int salary, DepartmentName Departmentname)
        {
            int count = 0;
            if (count < 1000)
            {
                return;
            }
            Fullname = fullname;
            Position = position;
            Salary = salary;
            
            switch ((int)Departmentname)
            {
                case 1000:
                    No += "MA" + count;
                        break;
                case 1001:
                    No += "MU" + count;
                        break;
                case 1002:
                    No += "IT" + count;
                    break;
                case 1003:
                    No += "IN" + count;
                    break;               
  
            }


        }

        public override string ToString()
        {
            return $"Name: {Fullname}\n No: {No}  ";
        }


    }
}
