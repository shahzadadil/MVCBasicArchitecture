namespace Tas.Data.Entities
{
    public class Product : AuditableEntity
    {        
        public string Name { get; set; }
        public double Price { get; set; }        
    }
}
