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
    /// Represents the single Position object view model.
    /// </summary>
    public partial class PositionViewModel : SingleObjectViewModel<Position, int, IMyQLNSDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PositionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PositionViewModel Create(IUnitOfWorkFactory<IMyQLNSDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PositionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PositionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PositionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PositionViewModel(IUnitOfWorkFactory<IMyQLNSDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Positions, x => x.Name) {
                }



    }
}
