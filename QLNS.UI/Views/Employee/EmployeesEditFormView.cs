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
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace QLNS.UI.Views.Employee
{
    [ViewType("EmployeeView")]
    public partial class EmployeesEditFormView : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeesEditFormView()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitBindings();
            }
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<EmployeeViewModel>();
            fluent.SetObjectDataSourceBinding( employeeBindingSource, x => x.Entity, x => x.Update());
            fluent.SetBinding(departmentBindingSource, dbs => dbs.DataSource, x => x.LookUpDepartments.Entities);
            fluent.SetBinding(positionBindingSource, pbs => pbs.DataSource, vm => vm.LookUpPositions.Entities);
            
        }

        private void LookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            if (e.Value != null) // && (int) e.Value == 0
            {
                e.DisplayText = lookUpEdit.Properties.NullText;
            } 
        }
    }
}
