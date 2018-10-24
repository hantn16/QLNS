using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private QLNSDbContext dbContext;
        public QLNSDbContext Init()
        {
            return dbContext ?? (dbContext = new QLNSDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            };
        }
    }
}
