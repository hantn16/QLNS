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

namespace QLNS.UI.Views.Employee
{
    [ViewType("EmployeeView")]
    public partial class EmployeesEditFormView : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeesEditFormView()
        {
            InitializeComponent();
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
    }
}
