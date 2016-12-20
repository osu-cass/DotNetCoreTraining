using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // TODO: Add Department models https://docs.microsoft.com/en-us/ef/core/modeling/relationships#many-to-many
        //public List<Department> Departments { get; set; }
    }
}
