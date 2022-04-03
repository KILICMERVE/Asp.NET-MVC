using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskDal _taskdal;

        public TaskManager(ITaskDal taskdal)
        {
            _taskdal = taskdal;
        }

        public List<AssingDetailDto> Assing()
        {
           return _taskdal.Assing();
        }

        public List<Task> GetAll()
        {
            return _taskdal.GetAll();
        }
    }
}
