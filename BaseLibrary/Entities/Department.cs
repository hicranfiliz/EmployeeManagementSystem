

namespace BaseLibrary.Entities
{
    public class Department : BaseEntity
    {
        // many to one relationship with GeneralDepartment
        public GeneralDepartment? GeneralDepartment { get; set; }
        public int GeneralDepartmentId { get; set; }

        //one to Many relationship with Branch
        public List<Branch>? Branches { get; set; }
    }
}
