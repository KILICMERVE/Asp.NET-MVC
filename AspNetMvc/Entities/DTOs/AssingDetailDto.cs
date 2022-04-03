using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AssingDetailDto:IDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Point { get; set; }
        public string TaskName { get; set; }
        public int Difficulty { get; set; }
        public int FirstPoint { get; set; }
    }
}
