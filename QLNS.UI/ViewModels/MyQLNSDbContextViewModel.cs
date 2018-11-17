using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using QLNS.UI.MyQLNSDbContextDataModel;

namespace QLNS.UI.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the MyQLNSDbContext data model.
    /// </summary>
    public partial class MyQLNSDbContextViewModel : DocumentsViewModel<MyQLNSDbContextModuleDescription, IMyQLNSDbContextUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";

        /// <summary>
        /// Creates a new instance of MyQLNSDbContextViewModel as a POCO view model.
        /// </summary>
        public static MyQLNSDbContextViewModel Create() {
            return ViewModelSource.Create(() => new MyQLNSDbContextViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the MyQLNSDbContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the MyQLNSDbContextViewModel type without the POCO proxy factory.
        /// </summary>
      //  protected MyQLNSDbContextViewModel()
		    //: base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
      //  }

        protected override MyQLNSDbContextModuleDescription[] CreateModules() {
			return new MyQLNSDbContextModuleDescription[] {
                new MyQLNSDbContextModuleDescription( "Departments", "DepartmentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Departments)),
                new MyQLNSDbContextModuleDescription( "Employees", "EmployeeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Employees)),
                new MyQLNSDbContextModuleDescription( "Positions", "PositionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Positions)),
                new MyQLNSDbContextModuleDescription( "Working Processes", "WorkingProcessCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.WorkingProcesses)),
			};
        }
                	}

    public partial class MyQLNSDbContextModuleDescription : ModuleDescription<MyQLNSDbContextModuleDescription> {
        public MyQLNSDbContextModuleDescription(string title, string documentType, string group, Func<MyQLNSDbContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}