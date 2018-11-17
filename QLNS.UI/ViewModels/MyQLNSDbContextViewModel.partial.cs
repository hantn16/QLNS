﻿using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using QLNS.UI.MyQLNSDbContextDataModel;
using QLNS.UI.ViewModels.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.UI.ViewModels
{
    public partial class MyQLNSDbContextViewModel
    {
        LoginViewModel loginViewModel;

        protected MyQLNSDbContextViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory())
        {
            loginViewModel = LoginViewModel.Create();
            loginViewModel.SetParentViewModel(this);
        }
        protected IDialogService DialogService
        {
            get { return this.GetService<IDialogService>(); }
        }
        protected IMessageBoxService MessageService
        {
            get { return this.GetService<IMessageBoxService>(); }
        }

        public override void OnLoaded(MyQLNSDbContextModuleDescription module)
        {
            base.OnLoaded(module);
            Login();
        }

        public virtual AppState State { get; set; }
        // Shows the Login View 
        public void Login()
        {
            OnLogin(DialogService.ShowDialog(MessageButton.OKCancel, "Please enter you credentials", "LoginView", loginViewModel));
        }
        //Occurs whenever the end-user clicks a dialog button 
        void OnLogin(MessageResult result)
        {
            if (result == MessageResult.Cancel)
                State = AppState.ExitQueued;
            else
            {
                if (loginViewModel.IsCurrentUserCredentialsValid)
                    State = AppState.Authorized;
                else
                    Login();
            }
        }
        protected void OnStateChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Logout());
            if (State == AppState.Authorized)
                Messenger.Default.Send<string>(loginViewModel.CurrentUser.UserName);
            else
                Messenger.Default.Send<string>(string.Empty);
        }

        public void Logout()
        {
            State = AppState.ExitQueued;
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.ExecutablePath);
        }

        public bool CanLogout()
        {
            return State == AppState.Authorized;
        }
        public override void OnClosing(CancelEventArgs cancelEventArgs)
        {
            base.OnClosing(cancelEventArgs);
            if (!cancelEventArgs.Cancel)
            {
                if (State == AppState.Authorized && MessageService.ShowMessage("Do you really want to close the application?", "Confirm", MessageButton.YesNo) == MessageResult.No)
                    cancelEventArgs.Cancel = true;
            }
        }
    }
    public enum AppState
    {
        NotAuthorized,
        Authorized,
        ExitQueued
    }
}
