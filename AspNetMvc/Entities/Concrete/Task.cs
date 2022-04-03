
using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Task:IEntity
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public int Difficulty { get; set; }
  
    }
}
