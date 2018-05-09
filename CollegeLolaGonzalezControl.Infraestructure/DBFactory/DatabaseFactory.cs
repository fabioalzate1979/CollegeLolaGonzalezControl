using AgileCode.SociaBPO.CommercialCRM.Infrastructure.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCode.SociaBPO.CommercialCRM.Infrastructure.Data.DBFactory.Factory
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private DBContext dataContext;
        public DbContext GetDatabase()
        {
            return dataContext ?? (dataContext = new DBContext());
        }

        public void Dispose()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
