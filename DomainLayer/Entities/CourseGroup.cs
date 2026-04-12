using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class CourseGroup:BaseEntity
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Room { get; set; }
        public object SeatCount { get; set; }

        public static implicit operator string(CourseGroup v)
        {
            throw new NotImplementedException();
        }
    }
}
