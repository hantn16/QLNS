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
using DevExpress.XtraGrid.Views.Grid;
using QLNS.UI.Helper;

namespace QLNS.UI.Views.Position
{
    [ViewType("PositionCollectionView")]
    public partial class PositionsView : UserControl
    {
        public PositionsView()
        {
            InitializeComponent();
            if(!DesignMode)
            {
                InitBindings();
            }

        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<PositionCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
            .SetBinding(x => x.SelectedEntity,
            args => args.Row as QLNS.Model.Models.Position,
            (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            fluent.WithEvent<RowCellClickEventArgs>(gridView1, "RowCellClick")
                .EventToCommand(
                    x => x.Edit(null), x => x.SelectedEntity, args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));
            GridViewHelper.ShowOrHideGridViewColumns(gridView1, new List<string> { "Employees","WorkingProcesses"},false);
        }
    }
}
