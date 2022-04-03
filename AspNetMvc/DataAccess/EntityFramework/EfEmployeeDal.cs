using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DataAccess.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, AspNetMvcContext>, IEmployeeDal
    {
        
    }
}
