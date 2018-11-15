using DevExpress.Utils.MVVM;
using QLNS.Data;
using QLNS.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.UI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitBindings();
            }
        }

        void InitBindings()
        {
            MVVMContextFluentAPI<MyQLNSDbContextViewModel> fluentAPI = mvvmContext1.OfType<MyQLNSDbContextViewModel>();
            fluentAPI.BindCommand(biDepartments, (context, module) => context.Show(module), context => context.Modules[0]);
            fluentAPI.BindCommand(biPositions, (context, module) => context.Show(module), context => context.Modules[1]);
            fluentAPI.BindCommand(biEmployees, (context, module) => context.Show(module), context => context.Modules[2]);
            fluentAPI.WithEvent(this, "Load").EventToCommand(context => context.OnLoaded(null), context => context.DefaultModule);
        }
    }
}
