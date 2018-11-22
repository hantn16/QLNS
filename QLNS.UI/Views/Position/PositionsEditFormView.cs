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

namespace QLNS.UI.Views.Position
{
    [ViewType("PositionView")]
    public partial class PositionsEditFormView : UserControl
    {
        public PositionsEditFormView()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitBindings();
            }
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<PositionViewModel>();
            fluent.SetObjectDataSourceBinding(positionBindingSource, x => x.Entity, x => x.Update());
        }
    }
}
