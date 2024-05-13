class Program {

    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }
        public int DepartmentID { get; set; }
    }


    class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }

    static void Main(String[] args)
    {

        List<Department> departments = new List<Department>{
                new Department { DepartmentID = 1, DepartmentName = "HR" },
                new Department { DepartmentID = 2, DepartmentName = "Finance" },
                new Department { DepartmentID = 3, DepartmentName = "IT" },
                new Department { DepartmentID = 4, DepartmentName = "Marketing" }
        };

        List<Employee> employees = new List<Employee>{
                new Employee { EmployeeID = 1, Name = "Alice", Age = 30, Salary = 60000, Gender = "Female", DepartmentID = 1 },
                new Employee { EmployeeID = 2, Name = "Bob", Age = 35, Salary = 70000, Gender = "Male", DepartmentID = 1 },
                new Employee { EmployeeID = 3, Name = "Charlie", Age = 40, Salary = 80000, Gender = "Male", DepartmentID = 2 },
                new Employee { EmployeeID = 4, Name = "David", Age = 25, Salary = 55000, Gender = "Male", DepartmentID = 2 },
                new Employee { EmployeeID = 5, Name = "Emma", Age = 28, Salary = 65000, Gender = "Female", DepartmentID = 3 },
                new Employee { EmployeeID = 6, Name = "Frank", Age = 32, Salary = 75000, Gender = "Male", DepartmentID = 3 },
                new Employee { EmployeeID = 7, Name = "Grace", Age = 27, Salary = 62000, Gender = "Female", DepartmentID = 4 },
                new Employee { EmployeeID = 8, Name = "Hannah", Age = 29, Salary = 68000, Gender = "Female", DepartmentID = 4 },
                new Employee { EmployeeID = 9, Name = "Ian", Age = 33, Salary = 72000, Gender = "Male", DepartmentID = 4 },
                new Employee { EmployeeID = 10, Name = "Julia", Age = 31, Salary = 78000, Gender = "Female", DepartmentID = 4 }
        };

        //1
        //var result1 = from d in departments
        //              join e in employees on d.DepartmentID equals e.DepartmentID
        //              group d by d.DepartmentName into Group
        //              select new
        //              {
        //                  name = Group.Key,
        //                  count = Group.Count()
        //              };

        //foreach (var item in result1)
        //{
        //    Console.WriteLine($"Department name {item.name} numbers of workers {item.count}");
        //}

        //2
        //var result = from d in departments
        //             join e in employees on d.DepartmentID equals e.DepartmentID
        //             group e by new { d.DepartmentName} into Group
        //             select new
        //             {
        //                 name = Group.Key.DepartmentName,
        //                 age = Group.Average(e => e.Age)
        //             };
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"Department name {item.name} avg age {item.age}");
        //}

        //3
        //var result = (from d in departments
        //             join e in employees on d.DepartmentID equals e.DepartmentID
        //             group e by new { d.DepartmentName } into Group
        //             orderby Group.Average(e => e.Salary) descending
        //             select new
        //             {
        //                 name = Group.Key.DepartmentName,
        //                 salary = Group.Average(e => e.Salary)
        //             }).First();

        //Console.WriteLine($"Highest salary have department{result.name} and it is {result.salary}");

        //4
        var result = from d in departments
                     join e in employees on d.DepartmentID equals e.DepartmentID into Group
                     select new
                     {
                         name = d.DepartmentName,
                         empl = Group.OrderByDescending(e=>e.Salary).First().Name
                     };

        foreach (var item in result)
        {
            Console.WriteLine($"department {item.name} empl:{item.empl}");
        }

        //5
        //var result = (from d in departments
        //             join e in employees on d.DepartmentID equals e.DepartmentID
        //             group e by new { d.DepartmentName, e.Gender } into Group
        //             where Group.Key.Gender == "Female"
        //             orderby Group.Count() descending
        //             select new
        //             {
        //                 name = Group.Key.DepartmentName
        //             }).First();


        //Console.WriteLine($"yvelaze meti muteli yavs {result.name}");





    }

}