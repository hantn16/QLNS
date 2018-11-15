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
    /// Represents the single Employee object view model.
    /// </summary>
    public partial class EmployeeViewModel : SingleObjectViewModel<Employee, long, IMyQLNSDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EmployeeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EmployeeViewModel Create(IUnitOfWorkFactory<IMyQLNSDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EmployeeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EmployeeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EmployeeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EmployeeViewModel(IUnitOfWorkFactory<IMyQLNSDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Employees, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Departments for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Department> LookUpDepartments {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeeViewModel x) => x.LookUpDepartments,
                    getRepositoryFunc: x => x.Departments);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeeViewModel x) => x.LookUpEmployees,
                    getRepositoryFunc: x => x.Employees);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Positions for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Position> LookUpPositions {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeeViewModel x) => x.LookUpPositions,
                    getRepositoryFunc: x => x.Positions);
            }
        }

    }
}
