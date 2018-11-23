using DevExpress.Utils.MVVM;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.UI.Helper
{
    public class GridViewHelper
    {
        public static void ShowOrHideGridViewColumns(GridView gridView, List<string> listClmName,bool isShow = true)
        {
            foreach (string gvc in listClmName)
            {
                gridView.Columns[gvc].Visible = isShow;
            }
        }
        public static void ShowOrHideGridViewColumns(GridView gridView, List<GridColumn> listClm, bool isShow = true)
        {
            foreach (GridColumn gvc in listClm)
            {
                gvc.Visible = isShow;
            }
        }

    }
}
