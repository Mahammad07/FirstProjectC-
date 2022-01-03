
using System;
using System.Collections.Generic;
using System.Text;

namespace department.Models
{
    class Department
    {
        public string Name { get; set; }

        public int WorkerLimit { get; set; }

        public int SalaryLimit { get; set; }

        public employee[] employees { get; set; }
        


        public Department(string name,int workerlimit,int salarylimit)
        {
            if (name.Length < 2)
            {
                Console.WriteLine("name has 2 letters at least");
            }
            Name = name;
            if (salarylimit < 250)
            {
                Console.WriteLine("salary should be over 250");
            }
            SalaryLimit = salarylimit;
            if (workerlimit <= 0)
            {
                Console.WriteLine("there should be 1 worker at least");
            }
            WorkerLimit = workerlimit;
        }






        public override string ToString ()
        {
            return $"ortalama maas:{SalaryLimit/WorkerLimit}";
        }



    }
}
