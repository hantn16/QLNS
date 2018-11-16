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

namespace QLNS.UI.Views.Department
{
    [ViewType("DepartmentView")]
    public partial class DepartmentsEditFormView : UserControl
    {
        public DepartmentsEditFormView()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitBindings();
            }
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<DepartmentViewModel>();
            fluent.SetObjectDataSourceBinding(departmentBindingSource, x => x.Entity, x => x.Update());
        }
    }
}
