
using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Point { get; set; }
        public int FirstPoint { get; set; }
        public int TaskId { get; set; }
    }
}
