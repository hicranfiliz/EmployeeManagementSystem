
namespace BaseLibrary.Entities;

public class Country : BaseEntity
{
    // one to many relationship with City
    public List<City>? Cities { get; set; }
}
