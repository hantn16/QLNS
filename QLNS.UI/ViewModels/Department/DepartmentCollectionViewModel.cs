using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using QLNS.UI.MyQLNSDbContextDataModel;
using QLNS.UI.Common;
using QLNS.Model.Models;

namespace QLNS.UI.ViewModels {

    /// <summary>
    /// Represents the Departments collection view model.
    /// </summary>
    public partial class DepartmentCollectionViewModel : CollectionViewModel<Department, int, IMyQLNSDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DepartmentCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DepartmentCollectionViewModel Create(IUnitOfWorkFactory<IMyQLNSDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DepartmentCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DepartmentCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DepartmentCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DepartmentCollectionViewModel(IUnitOfWorkFactory<IMyQLNSDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Departments) {
        }
    }
}