using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InBizOnion.Infrastructure.Interface
{
    public interface IConfigService
    {
        IDatabaseContext DatabaseContext { get; }
    }
}
