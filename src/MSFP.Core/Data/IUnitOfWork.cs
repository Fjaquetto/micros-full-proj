using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFP.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
