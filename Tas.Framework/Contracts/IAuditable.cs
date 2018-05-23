using System;

namespace Tas.Framework.Contracts
{
    public interface IAuditable
    {
        int CreatedBy { get; set; }
        int ModifiedBy { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
    }
}
