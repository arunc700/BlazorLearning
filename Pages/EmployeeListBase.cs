using BlazorAppDemo.Services;
using LearningModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppDemo.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        //Inject services because we can not use contructor in blazor component

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        private void LoadEmployee()
        {


            System.Threading.Thread.Sleep(1000);
            Employee e1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Arun",
                LastName = "Singh",
                DateOfBirth = new DateTime(1990, 12, 12),
                //Department = new Department() { DepartmentId = 1, DepartmentName = "Computer" },
                DepartmentId = 1,
                Email = "arun@gmail.com",
                Gender = Gender.Male,
                PhotoPath = "images/img1.png"

            };

            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "Ram",
                LastName = "Pandey",
                DateOfBirth = new DateTime(1990, 12, 12),
                //Department = new Department() { DepartmentId = 1, DepartmentName = "IT" },
                DepartmentId = 1,
                Email = "ram@gmail.com",
                Gender = Gender.Male,
                PhotoPath = "images/img2.png"

            };

            Employee e3 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "Pankaj",
                LastName = "Pandey",
                DateOfBirth = new DateTime(1990, 12, 12),
                //Department = new Department() { DepartmentId = 1, DepartmentName = "IT" },
                DepartmentId = 1,
                Email = "pankaj@gmail.com",
                Gender = Gender.Male,
                PhotoPath = "images/img3.png"

            };

            Employees = new List<Employee> { e1, e2, e3 };
        }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

    }
}
