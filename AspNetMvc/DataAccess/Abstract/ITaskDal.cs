using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITaskDal:IEntityRepository<Task>
    {
        List<AssingDetailDto> GetAssingDetails();
        List<AssingDetailDto> Assing();
    }
}
