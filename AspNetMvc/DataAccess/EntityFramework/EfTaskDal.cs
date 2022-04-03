using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfTaskDal : EfEntityRepositoryBase<Task, AspNetMvcContext>, ITaskDal
    {

        public List<AssingDetailDto> GetAssingDetails()
        {
            using (AspNetMvcContext context = new AspNetMvcContext())
            {
                var result = from e in context.Employees
                             join t in context.Tasks
                             on e.TaskId equals t.Id
                             select new AssingDetailDto
                             {
                                 Id = e.Id,
                                 FirstName = e.FirstName,
                                 LastName = e.LastName,
                                 FirstPoint = e.FirstPoint,
                                 Point = e.Point,
                                 TaskName = t.TaskName,
                                 Difficulty = t.Difficulty
                             };
                return result.ToList();
            }
        }

        public List<AssingDetailDto> Assing()
        {

            using (AspNetMvcContext context =new AspNetMvcContext())
            {
                //--------------------Personeller görevlerinin zorluk derecesi kadar puan toplar----------------------------------------------------
                //----------------------------Aynı puana sahip personeller olması durumunda hata almamak için eşit puanlar değiştirilir-------------------------
                int counter = 0;
                List<int> points = new List<int>();
                List<Employee> employees = context.Set<Employee>().OrderByDescending(e=>e.Point).ToList();
                points.Add(employees.First().Point);

                for (int i = 1; i < employees.Count; i++)
                {
                    if (!points.Contains(employees[i].Point))
                    {
                        points.Add(employees[i].Point);
                    }
                    else
                    {
                        counter++;
                        Employee e = context.Set<Employee>().SingleOrDefault(x => x.Id == employees[i].Id);
                        e.Point += counter * 10;
                        context.SaveChanges();
                        points.Add(e.Point + counter * 10);
                    }

                }

                
                //-----------------------------------En az puana sahip olan personele en zor görev atanır.Daha sonra detaylar listelenir-------------------
                List<Task> task = context.Set<Task>().OrderBy(t => t.Difficulty).ToList();
                List<Employee> employee = context.Set<Employee>().OrderByDescending(e => e.Point).ToList();
                for (int i = 0; i < employee.Count; i++)
                {
                    Employee emply = context.Set<Employee>().SingleOrDefault(e => e.Point == employee[i].Point);
                    Task t = context.Set<Task>().SingleOrDefault(x => x.Difficulty == task[i].Difficulty);
                    emply.FirstPoint = emply.Point;
                    emply.Point += t.Difficulty;
                    emply.TaskId = t.Id;
                    context.SaveChanges();
                   
                }


            }
            List<AssingDetailDto> result = GetAssingDetails();
            return result;
        }
    }
}
