using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.UI.ViewModels.Login;

namespace QLNS.UI.Views.Login
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }
        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            var fluentAPI = mvvmContext1.OfType<LoginViewModel>();
            fluentAPI.SetObjectDataSourceBinding(userBindingSource, x => x.CurrentUser, x => x.Update());
            UserNameLookUpEdit.Properties.DataSource = mvvmContext1.GetViewModel<LoginViewModel>().LookUpUsers.ToList();
            fluentAPI.ViewModel.Init();
        }
    }
}
