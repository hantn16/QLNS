using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using QLNS.Data;
using System;
using System.Collections;
using System.Linq;

namespace QLNS.UI.MyQLNSDbContextDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IMyQLNSDbContextUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IMyQLNSDbContextUnitOfWork>(() => new MyQLNSDbContextUnitOfWork(() => new MyQLNSDbContext()));
        }
    }
}