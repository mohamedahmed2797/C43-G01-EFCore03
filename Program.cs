using C43_G01_EFCore03.Context;
using C43_G01_EFCore03.Data;
using Microsoft.EntityFrameworkCore;

namespace C43_G01_EFCore03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ItiContext context = new ItiContext();

            //Student student = new Student()
            //{
            //    FName = "mohamed",
            //    LName = "ahmed",
            //    Age = 23,
            //    Address = "giza",

            //};
            //context.Students.Add(student);
            //List<Student> students = new List<Student> 
            //{
            //    new Student() {FName = "ahmed" , LName = "kamal" , Age = 59 , Address = "giza"} , 
            //    new Student() {FName = "khaled" , LName = "sayed" , Age = 25 , Address = "cairo" }

            //};
            //context.Students.AddRange(students);
            //context.SaveChanges();
            //Department department = new Department()
            //{
            //    Name = "Hr",
            //    HiringDate = new DateOnly(2025, 10, 25)
            //};
            //if (department is not null)
            //{
            //    context.Departments.Add(department);
            //    context.SaveChanges();
            //}
            //----------------------------------------------------------------
            //var student = context.Students.FirstOrDefault(s => s.Id == 1);
            //if (student is not null)
            //{
            //    Console.WriteLine($"Name is {student.FName} { student.LName } \n Age = { student.Age}");
            //}
            //----------------------------------------------------------------
            //var student = context.Students.FirstOrDefault(s => s.Id == 3);
            //if (student is not null)
            //{
            //    student.FName = "Salma";
            //}
            //context.SaveChanges();
            //----------------------------------------------------------------
            //var student = context.Students.FirstOrDefault(s => s.Id == 3);
            //if (student is not null)
            //{
            //    context.Students.Remove(student);
            //}
            //context.SaveChanges();

            //var result = context.Students.Include(e => e.Dept_Id).FirstOrDefault(d => d.Id == 1);
            //if (result is not null)
            //{
            //    Console.WriteLine($"{result.FName} {result.LName} \n {result?.Dept_Id?.Name}");
            //}



            var result02 = context.Students.Include(s => s.Dept_Id).FirstOrDefault(s => s.Id == 1);
            if (result02 != null)
            {
                Console.WriteLine(result02.FName);
                Console.WriteLine(result02?.Dept_Id?.Name);
            }
        }
    }
}