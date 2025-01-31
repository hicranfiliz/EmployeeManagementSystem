
namespace BaseLibrary.Entities
{
    public class Town : BaseEntity
    {
        // many to one relationship with City
        public City? City { get; set; }
        public int CityId { get; set; }

        // one to many relationship with Employees
        public List<Employee>? Employees { get; set; }
    }
}
