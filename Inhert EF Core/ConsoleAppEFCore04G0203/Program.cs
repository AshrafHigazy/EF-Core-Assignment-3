using InhertEFCore.Contexts;
using InhertEFCore.Models;

namespace InhertEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inhert EF Core
            //using TestContext context = new TestContext();

            //Employee employee = new Employee()
            //{
            //    Name = "Higzo"
            //};
            //context.Employees.Add(employee);

            //FullTimeEmployee FTEmployee = new FullTimeEmployee()
            //{
            //    Name = "Ashraf",
            //    Age = 20,
            //    StartDate = DateOnly.FromDateTime(DateTime.Now),
            //    Salary = 20000
            //};
            //context.Employees.Add(FTEmployee);

            //PartTimeEmployee PTEmployee = new PartTimeEmployee()
            //{
            //    Name = "Mazen",
            //    Age = 22,
            //    HourRate = 600,
            //    CountOfHours = 40
            //};

            //context.Employees.Add(PTEmployee);

            //context.SaveChanges();

            //var Emps = context.Employees;

            //if (Emps?.Count() > 0)
            //{
            //    foreach (var employee in Emps.OfType<FullTimeEmployee>())
            //    {
            //        Console.WriteLine(employee.Name);
            //        Console.WriteLine(employee.Salary);

            //    }
            //    Console.WriteLine("====================================================");
            //    foreach (var employee in Emps.OfType<PartTimeEmployee>())
            //    {
            //        Console.WriteLine(employee.Name);
            //        Console.WriteLine(employee.HourRate);

            //    }
            //}

            #endregion


        }
    }
}
