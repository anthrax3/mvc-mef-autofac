using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approach1.Core.Data.Base
{
    public interface IUnitOfWork
    {
        int Commit();
        bool KeepContextLive { get; set; }
    }
}
