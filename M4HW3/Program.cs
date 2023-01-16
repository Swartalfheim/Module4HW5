using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace M4HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext ctx = new ApplicationContext())
            {
                Console.WriteLine("Data output from three tables:");
                var users = ctx.EmployeesProjects.ToList();
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Employee.FirstName}, {user.Rate}, {user.Project.Name}");
                }
                Console.WriteLine();
                Console.WriteLine("Difference between today's date and date of birth, in years:");
                var users1 = ctx.Employees.ToList();
                foreach (var user in users1)
                {
                    Console.WriteLine(user.HiredDate.Year - user.DateOfBirth.Year);
                }
                var up = ctx.Employees.FirstOrDefault();
                up.FirstName = up.FirstName + "En";
                ctx.SaveChanges();
                Console.WriteLine();
                Console.WriteLine("Data output where the role name does contain \"a\":");
                var users2 = ctx.Offices.ToList();
                string n = " ";
                foreach (var user in users2)
                {
                    for (int i = 0; i < user.Title.Length; i++)
                    {
                        if (user.Title[i] == 'a')
                        {
                            n = user.Title;
                        }
                    }
                    Console.WriteLine(n);
                }
                Console.WriteLine();
                var users3 = ctx.Offices
                    .FromSqlRaw("SELECT * FROM [dbo].[Office]")
                    .ToList();
                foreach (var user in users3)
                {
                    Console.WriteLine(user.Title);
                }
            }
        }
    }
}