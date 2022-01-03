
using department.Models;
using System;

namespace department
{
    class Program
    {
        static void Main(string[] args)
        {
            //employee Employee1 = new employee("Azad Azadaov", 36, DepartmentName.Muhafize);
            //employee Employee2 = new employee("Kerim Aslanov",47,DepartmentName.Maliyyet);
            //employee Employee3 = new employee("Kenan Melikli",88,DepartmentName.Innovation);
            //employee Employee4 = new employee("Arzu Abbasova",74,DepartmentName.It);


            //Console.WriteLine(Employee1);
            //Console.WriteLine(Employee2);
            //Console.WriteLine(Employee3);
            //Console.WriteLine(Employee4);
            //Department Company = new Department(2500,25);

            
            //Company.CalcSalaryAverage(2500,25);

            HumanResourceManager humanResourceManager = new HumanResourceManager();
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------------Department Management-----------------------------");
                Console.WriteLine("Etmek istediyiniz emeliyata uygun reqemi daxil edin");
                Console.WriteLine("1-Department siyahisini gostermek");
                Console.WriteLine("2-Deparrment yaratmaq");
                Console.WriteLine("3-Departmentde deyisiklik etmek");
                Console.WriteLine("4-Iscilerin sayini gosdermek");
                Console.WriteLine("5-Departmentdeki iscilerin siyahisini gosdermek");
                Console.WriteLine("6-Isci elave etmek");
                Console.WriteLine("7-Isci uzerinde deyisiklik etmek");
                Console.WriteLine("8-Departmentdeki iscinin silinmesi");

                string choose = Console.ReadLine();
                int chooseNum;
                int.TryParse(choose, out chooseNum);
                switch (chooseNum)
                {
                    case 1:
                        Console.Clear();
                        GetDepartment(ref humanResourceManager);
                        break;
                    case 2:
                        Console.Clear();
                        AddDepartment(ref humanResourceManager);
                        break;
                    case 3:
                        Console.Clear();
                        EditDepartment(ref humanResourceManager);
                        break;
                    case 4:
                        Console.Clear();

                            break;
                    case 5:
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        AddEmployee(ref humanResourceManager);
                        break;
                    case 7:
                        Console.Clear();
                        EditEmployee(ref humanResourceManager);
                        break;
                    case 8:
                        Console.Clear();
                        RemoveEmployee(ref humanResourceManager);
                        break;
                    default:
                        break;
                }
            } while (true);

            static void GetDepartment(ref HumanResourceManager humanResourceManager)
            {
                Console.WriteLine("departmenleri gormek ucun 1 duymesini basin");
                string No=Console.ReadLine();
                int intNo;
                int .TryParse(No, out intNo);

                if (humanResourceManager.departmens.Length < 1)
                {
                    Console.WriteLine("sirketde department qurulmayib");
                }
                else
                {
                    foreach (Department item in humanResourceManager.departmens)
                    {
                        Console.WriteLine($"name:{item.Name}");
                        Console.WriteLine($"isci sayi:{item.employees.Length}");
                        Console.WriteLine($"OrtalamaGelir:{item.ToString()}");
                    }
                }

            }

            static void AddDepartment(ref HumanResourceManager humanResourceManager)
            {
                Console.WriteLine("Departmentin adini daxil edin:");
                string name = Console.ReadLine();

               

                Console.WriteLine("Maksimum verilecek maasi daxil edin:");
                string salaryLimit = Console.ReadLine();
                int salary;
                
                while (int.TryParse(salaryLimit, out salary) && salary < 250) 
                {

                    Console.WriteLine("maas 250 den yuxari olmalidir.Duzgun maas yazin:");
                    salaryLimit = Console.ReadLine();




                }
      
                Console.WriteLine("Maksimum isci sayini daxil edin:");
                string workerLimit =Console.ReadLine();
                int workerNum;
               Console.Clear();
                while (int.TryParse(workerLimit, out workerNum) && workerNum < 1) 
                {
                    Console.WriteLine("isci sayi 1 den asagi ola bilmez");
                    

                    workerLimit = Console.ReadLine();


                }
               

                humanResourceManager.AddDepartment(name, salary, workerNum);
            }

            static void AddEmployee(ref HumanResourceManager humanResourceManager)
            {
                Console.WriteLine("Iscinin departmentini yazin:");
                string DepartmentName=Console.ReadLine();

                if (DepartmentName.Length < 2)
                {
                    Console.WriteLine("Department adi yanlisdir");
                }
                else
                {
                    
                    DepartmentName = Console.ReadLine();
                }
                Console.WriteLine("Iscinin adini yazin:");
                string fullname = Console.ReadLine();

                Console.WriteLine("Iscinin vezifesinin yazin:");
                string position = Console.ReadLine();
                

                Console.WriteLine("Iscinin maasini yazin:");
                string salary = Console.ReadLine();
                int salaryNum;

                int.TryParse(salary, out salaryNum);

                if (salaryNum < 250)
                {
                    Console.WriteLine("Iscinin maasi 250 den asagi ola bilmez");
                }
                else
                {
                    salary = Console.ReadLine();
                }


                
                

                humanResourceManager.AddEmployee(fullname,position,salaryNum, DepartmentName);
            }

            static void RemoveEmployee(ref HumanResourceManager humanResourceManager)
            {
                Console.WriteLine("Departmentin adini yazin:");
                string departmentName = Console.ReadLine();
                if(departmentName.Length < 2)
                {
                    Console.WriteLine("Department adi duzgun deil");
                }
                else
                {
                    departmentName = Console.ReadLine();
                }



                Console.WriteLine("Iscinin nomresini yazin:");
                string employeeNo = Console.ReadLine();
                int employeeNum;

                int.TryParse(employeeNo, out employeeNum);
                if (employeeNum < 1000)
                {
                    Console.WriteLine("Isci nomresi 1000 den boyuk olmalidir");
                }
                else
                {
                    employeeNo= Console.ReadLine();
                }




                
                
                
                humanResourceManager.RemoveEmployee(employeeNo, departmentName);

                
            }

           static void EditEmployee (ref HumanResourceManager humanResourceManager)
            {
                Console.WriteLine("Iscinin nomresinin yazin:");
                string employeeNo = Console.ReadLine();
                if (employeeNo == null)
                {
                    Console.WriteLine("Bu nomreye aid isci yoxdur");
                }
                else
                {
                    employeeNo = Console.ReadLine();
                }
                Console.WriteLine("Iscinin adini ve soyadini yazin:");
                string fullname = Console.ReadLine();
                if (fullname == null)
                {
                    Console.WriteLine("Bu adda isci yoxdur");
                }
                else
                {
                    fullname = Console.ReadLine();
                }


                Console.WriteLine("Iscinin maasini yazin:");
                string maas = Console.ReadLine();
                int maasNum;
                int.TryParse(maas, out maasNum);
                if (maasNum < 250)
                {
                    Console.WriteLine("Maas 250 den yuxari olmalidir");
                }
                else
                {
                    maas = Console.ReadLine();
                }

                Console.WriteLine("Iscinin vezifesini yazin:");
                string position = Console.ReadLine();
                if (position == null)
                {
                    Console.WriteLine("Bele bir vezife yoxdur");
                   
                }
                else
                {
                     position = Console.ReadLine();
                }
                Console.WriteLine("Iscinin yeni maasini yazin");
                string newSalary = Console.ReadLine();
                int newSalarynum;
                int.TryParse(newSalary, out newSalarynum);
                if (newSalarynum < 250)
                {
                    Console.WriteLine("Iscinin maasi 250 den yuxari olmalidir");
                }
                else
                {
                    newSalary = Console.ReadLine();
                }

                Console.WriteLine("Iscinin yeni vezifesini yazin:");
                string newPosition=Console.ReadLine();
                if (newPosition == null)
                {
                    Console.WriteLine("Bele bir vezife yoxdur");
                }
                else
                {
                    newPosition = Console.ReadLine();
                }

                humanResourceManager.EditEmployee(employeeNo,fullname,maasNum,position, newSalarynum, newPosition);
            }


            static void EditDepartment(ref HumanResourceManager humanResourceManager)
            {
                Console.WriteLine("Departmentin adini yazin:");
                string departmentName = Console.ReadLine();
                {
                   if(departmentName == null)
                    {
                        Console.WriteLine("Bele bir department yoxdur");
                    }
                    else
                    {
                        departmentName = Console.ReadLine();
                    }

                    Console.WriteLine("Departmentin maksimum massini yazin:");
                    string salaryLimit = Console.ReadLine();
                    int salaryNum;
                    int.TryParse(salaryLimit, out salaryNum);
                    if (salaryNum < 250)
                    {
                        Console.WriteLine("Maas 250den yuxari olmalidir");
                    }
                    else
                    {
                        salaryLimit = Console.ReadLine();
                    }

                    Console.WriteLine("Departamentin maksimum isci sayini yazin");
                    string workerlimit = Console.ReadLine();
                    int workerlimitNum;
                    int.TryParse(workerlimit, out workerlimitNum);
                    if (workerlimitNum < 1)
                    {
                        Console.WriteLine("Departmentdeki isci sayi 1 den yuxari olamlidir");
                    }
                    else
                    {
                        workerlimit = Console.ReadLine();
                    }

                    Console.WriteLine("Yeni maksimum maasi yazin:");
                    string newsalaryLimit = Console.ReadLine();
                    int newsalaryNum;
                    int.TryParse(salaryLimit, out newsalaryNum);
                    if (newsalaryNum < 250)
                    {
                        Console.WriteLine("Maas 250den yuxari olmalidir");
                    }
                    else
                    {
                        newsalaryLimit = Console.ReadLine();
                    }

                    Console.WriteLine("Yeni maksmimum isci sayini yazin:");
                    string newworkerlimit = Console.ReadLine();
                    int newworkerlimitNum;
                    int.TryParse(workerlimit, out newworkerlimitNum);
                    if (newworkerlimitNum < 1)
                    {
                        Console.WriteLine("Departmentdeki isci sayi 1 den yuxari olamlidir");
                    }
                    else
                    {
                        newworkerlimit = Console.ReadLine();
                    }
                    humanResourceManager.EditDepartment(departmentName, workerlimitNum, newworkerlimitNum, salaryNum, newsalaryNum);


                }

               
                    
                }

            }

         






        }
    }





