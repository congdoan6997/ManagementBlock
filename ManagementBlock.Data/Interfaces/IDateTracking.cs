using System;

namespace ManagementBlock.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { get; set; }

        DateTime DateModified { get; set; }
    }
}
