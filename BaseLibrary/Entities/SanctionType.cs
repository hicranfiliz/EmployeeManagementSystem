
namespace BaseLibrary.Entities
{
    public class SanctionType : BaseEntity
    {
        //One to many relationship with Sanction
        public List<Sanction> Sanctions { get; set; }
    }
}
