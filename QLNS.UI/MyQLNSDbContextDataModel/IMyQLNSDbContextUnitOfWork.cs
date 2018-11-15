using DevExpress.Mvvm.DataModel;
using QLNS.Data;
using QLNS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLNS.UI.MyQLNSDbContextDataModel {

    /// <summary>
    /// IMyQLNSDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IMyQLNSDbContextUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Department entities repository.
        /// </summary>
		IRepository<Department, int> Departments { get; }
        
        /// <summary>
        /// The Employee entities repository.
        /// </summary>
		IRepository<Employee, long> Employees { get; }
        
        /// <summary>
        /// The Position entities repository.
        /// </summary>
		IRepository<Position, int> Positions { get; }
        
        /// <summary>
        /// The WorkingProcess entities repository.
        /// </summary>
		IRepository<WorkingProcess, long> WorkingProcesses { get; }
    }
}
