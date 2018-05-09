using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCode.SociaBPO.CommercialCRM.Infrastructure.Data.DBFactory.Factory
{
    public interface IDatabaseFactory
    {
        DbContext GetDatabase();
    }
}
