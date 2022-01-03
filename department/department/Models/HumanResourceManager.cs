
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

        public HumanResourceManager()
        {
            _departments = new Department[0];
            _employee = new employee[0];

        }

        public void AddDepartment(string name, int salarylimit, int workerlimt)
        {
            Department department = new Department(name, salarylimit, workerlimt);
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



        public void AddEmployee(string fullname, string position, int salary,string  departmentname)
        {
            foreach (Department item in _departments)
            {
              if(  item.Name == departmentname)
              
                {
                    employee employees = new employee(fullname, position, salary, departmentname);
                    Array.Resize(ref _employee, _employee.Length + 1);
                    _employee[_employee.Length - 1] = employees;
                }
            }
            
            
        }

        public void RemoveEmployee(string employeeNo, string departmentName)
        {
            foreach (Department item in _departments)
            {
                if (item.Name == departmentName) 
                {
                    for (int i = 0; i < _employee.Length; i++)
                    {
                        if (_employee[i] != null && _employee[i].No == employeeNo)
                        {
                            _employee[i] = null;
                            return;
                        }

                    }

                }
            }
           
        }

        

        

    }
}
