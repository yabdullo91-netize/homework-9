using System;
using Domain.Models;
using Infrastructure.Services;
   var employee1=new Employee
   {
       Firstname="abdullo",
       Lastname="YAkubov",
       BirthDate=new DateTime(2004,02,28),
       Salary=100.00m,
   };
     var employee2=new Employee
   {
       Firstname="aziz",
       Lastname="YAkubov",
       BirthDate=new DateTime(2007,05,21),
       Salary=300.00m,
   };
   EmployeeService employee =new EmployeeService();
   employee.AddEmployees(employee1);
   employee.AddEmployees(employee2);
   List<Employee>employees=employee.GetEmployees();
   foreach (var item in employees)
   {
    System.Console.WriteLine($"name-{item.Firstname}");    
    System.Console.WriteLine($"Lastname-{item.Lastname}");    
    System.Console.WriteLine($"Day-{item.BirthDate}");    
    System.Console.WriteLine($"Salery-{item.Salary}");
    System.Console.WriteLine();    
   }
   System.Console.WriteLine($"рабочие-{employee.CountEmployees()}");



      var department1=new Department
   {
      Name="ali",
      Description="it"
   };
     var depaartment2=new Department
   {
        Name="ali",
      Description="it"
   };
   DepartmentService em =new DepartmentService();
   em.AddDepartments(department1);
   em.AddDepartments(depaartment2);
   List<Department> it=em.GetDepartments();
   foreach (var item in it)
   {
    System.Console.WriteLine($"name-{item.Name}");    
    System.Console.WriteLine($"it-{item.Description}");    
    System.Console.WriteLine();    
   }
   System.Console.WriteLine($"рабочие-{em.CountDepartments()}");
   
   