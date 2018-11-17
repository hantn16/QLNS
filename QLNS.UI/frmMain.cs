using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
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
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Opacity = 0;
            if (!DesignMode)
            {
                InitBindings();
            }
            mvvmContext1.RegisterService(DocumentManagerService.Create(tabbedView1));
            ribbonControl1.Merge += ribbonControl1_Merge;
        }
        void ribbonControl1_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            ribbonControl1.SelectedPage = e.MergedChild.SelectedPage;
        }
        void InitBindings()
        {
            MVVMContextFluentAPI<MyQLNSDbContextViewModel> fluentAPI = mvvmContext1.OfType<MyQLNSDbContextViewModel>();
            fluentAPI.BindCommand(biDepartments, (context, module) => context.Show(module), context => context.Modules[0]);
            fluentAPI.BindCommand(biPositions, (context, module) => context.Show(module), context => context.Modules[2]);
            fluentAPI.BindCommand(biEmployees, (context, module) => context.Show(module), context => context.Modules[1]);
            fluentAPI.WithEvent(this, "Load").EventToCommand(context => context.OnLoaded(null), context => context.DefaultModule);

            fluentAPI.SetTrigger(x => x.State, (state) =>
            {
                if (state == AppState.Autorized)
                    Opacity = 1; /*Show Main Form*/
                if (state == AppState.ExitQueued)
                    Close(); // exit the app; 
            });
        }
    }
}
