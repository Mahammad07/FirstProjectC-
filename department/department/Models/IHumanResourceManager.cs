
using System;
using System.Collections.Generic;
using System.Text;
using department.Models;

namespace department.Models
{
    interface IHumanResourceManager
    {
         Department[] departmens { get; }
         employee[]  employees { get;}

        void AddDepartment(string name,int salarylimit,int workerlimt);

         Department[] GetDepartment();
        void EditDepartment(string departmentname, int workerlimit,int newworkerlimit, int salarylimit, int newSalarylimit);

        void AddEmployee(string fullname ,string position,int salary, string departmentName);

        void RemoveEmployee(string employeeNo,string departmentName);

        void EditEmployee(string employeeNo, string fullname, int salary, string position,   int newSalary, string newPosition);


        









    }
}
