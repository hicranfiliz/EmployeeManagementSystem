using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class GeneralDepartment : BaseEntity
    {
        // one to many relationship with Department
        public List<Department>? Departments { get; set; }   
    }
}
