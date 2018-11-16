using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.MVVM.UI;
using QLNS.UI.ViewModels;
using DevExpress.XtraGrid.Views.Base;

namespace QLNS.UI.Views.Department
{
    [ViewType("DepartmentCollectionView")]
    public partial class DepartmentsView : UserControl
    {
        public DepartmentsView()
        {
            InitializeComponent();
            if(!DesignMode)
            {
                InitBindings();
            }

        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<DepartmentCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity,
                args => args.Row as QLNS.Model.Models.Department,
                (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
        }
    }
}
