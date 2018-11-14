using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using QLNS.UI.MyQLNSDbContextDataModel;
using QLNS.UI.Common;
using QLNS.Model.Models;

namespace QLNS.UI.ViewModels {

    /// <summary>
    /// Represents the single WorkingProcess object view model.
    /// </summary>
    public partial class WorkingProcessViewModel : SingleObjectViewModel<WorkingProcess, long, IMyQLNSDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of WorkingProcessViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static WorkingProcessViewModel Create(IUnitOfWorkFactory<IMyQLNSDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new WorkingProcessViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the WorkingProcessViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the WorkingProcessViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected WorkingProcessViewModel(IUnitOfWorkFactory<IMyQLNSDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.WorkingProcesses, x => x.MetaDescription) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Departments for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Department> LookUpDepartments {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (WorkingProcessViewModel x) => x.LookUpDepartments,
                    getRepositoryFunc: x => x.Departments);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (WorkingProcessViewModel x) => x.LookUpEmployees,
                    getRepositoryFunc: x => x.Employees);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Positions for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Position> LookUpPositions {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (WorkingProcessViewModel x) => x.LookUpPositions,
                    getRepositoryFunc: x => x.Positions);
            }
        }

    }
}
