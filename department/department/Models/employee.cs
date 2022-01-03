

using System;
using System.Collections.Generic;
using System.Text;

namespace department.Models
{
    class employee
    {
        public static int Count = 1000; 
        public string No { get; set; }

        public string Fullname { get; set; }

        public string Position { get; set; }

        public int Salary { get; set; }

        public string DepartmentName { get; set; }

        



        public employee(string fullname, string position,int salary, string departmentName)
        {
            
            Fullname = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentName;

            No += departmentName.Substring(0, 2) + Count;
            
           


        }

        public override string ToString()
        {
            return $"Name: {Fullname}\n No: {No}  ";
        }


    }
}
