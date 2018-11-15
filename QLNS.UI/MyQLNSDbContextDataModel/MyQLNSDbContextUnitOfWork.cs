using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using QLNS.Data;
using QLNS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLNS.UI.MyQLNSDbContextDataModel {

    /// <summary>
    /// A MyQLNSDbContextUnitOfWork instance that represents the run-time implementation of the IMyQLNSDbContextUnitOfWork interface.
    /// </summary>
    public class MyQLNSDbContextUnitOfWork : DbUnitOfWork<MyQLNSDbContext>, IMyQLNSDbContextUnitOfWork {

        public MyQLNSDbContextUnitOfWork(Func<MyQLNSDbContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Department, int> IMyQLNSDbContextUnitOfWork.Departments {
            get { return GetRepository(x => x.Set<Department>(), (Department x) => x.Id); }
        }

        IRepository<Employee, long> IMyQLNSDbContextUnitOfWork.Employees {
            get { return GetRepository(x => x.Set<Employee>(), (Employee x) => x.Id); }
        }

        IRepository<Position, int> IMyQLNSDbContextUnitOfWork.Positions {
            get { return GetRepository(x => x.Set<Position>(), (Position x) => x.Id); }
        }

        IRepository<WorkingProcess, long> IMyQLNSDbContextUnitOfWork.WorkingProcesses {
            get { return GetRepository(x => x.Set<WorkingProcess>(), (WorkingProcess x) => x.Id); }
        }
    }
}
