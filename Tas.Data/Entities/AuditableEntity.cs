using System;
using Tas.Framework.Contracts;

namespace Tas.Data.Entities
{
    public class AuditableEntity : IIdentifiable, IAuditable
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
