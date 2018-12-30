using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementBlock.Infrastructure.Interfaces
{
   public interface IUnitOfWork:IDisposable
    {
        /// <summary>
        /// Call Save Change db Context
        /// </summary>
        void Commit();
    }
}
