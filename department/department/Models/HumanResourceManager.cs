using department.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace department.Models
{
    class HumanResourceManager : IHumanResourceManager
    {
        public Department[] departmens => _departments;
        private Department[] _departments;
        public employee[] employees => _employee;

        private employee[] _employee;

        public void AddDepartment(string name, int salarylimit, int workerlimt, employee[] employees)
        {
            Department department = new Department(name, salarylimit, workerlimt, employees);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = department;
        }

        public Department[] GetDepartment()
        {
            return _departments;
        }



        public void EditDepartment(string departmentname, int workerlimit,int newworkerlimit,int salarylimit,int newSalarylimit)
        {
            foreach (Department department in _departments)
            {
                if (department.Name != departmentname)
                {
                    
                    return;
                }

                if (department.SalaryLimit == salarylimit)
                {
                    department.SalaryLimit = newSalarylimit;
                }

                if (department.WorkerLimit == workerlimit)
                {
                    department.WorkerLimit = newworkerlimit;
                }
            }
        }

        public void EditEmployee(string employeeNo, string fullname, int employeSalary, string position, int newSalary, string newPosition)
        {
            foreach (employee item in _employee)
            {
                if (item.Fullname != fullname)
                {
                    return;
                }

                if (item.No != employeeNo)
                {
                    return;
                }

                if (item.Salary == employeSalary)
                {
                    item.Salary = newSalary;
                    break;
                }

                if (item.Position == position)
                {
                    item.Position = newPosition;
                    break;
                }
            }
        }



        public void AddEmployee(string fullname, string position, int salary,DepartmentName departmentName)
        {
            employee employees = new employee(fullname ,position,salary,departmentName );
            Array.Resize(ref _employee, _employee.Length + 1);
            _employee[_employee.Length - 1] = employees;
        }

        public void RemoveEmployee(string employeeNo, DepartmentName departmentName)
        {
            for (int i = 0; i < _employee.Length; i++)
            {
               if(_employee[i]!=null &&  _employee[i].No == employeeNo )
                {
                    _employee[i] = null;
                    return;
                }

            }

        }

        public void RemoveEmployee(string employeeNo)
        {
            throw new NotImplementedException();
        }

        public void EditDepartment(string name, int newworkerlimit, int salarylimit, int newSalarylimit)
        {
            throw new NotImplementedException();
        }
    }
}
