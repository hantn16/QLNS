namespace QLNS.UI.Views.Position
{
    partial class PositionsEditFormView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.EmployeesGridControl = new DevExpress.XtraGrid.GridControl();
            this.ItemForEmployees = new DevExpress.XtraLayout.LayoutControlItem();
            this.WorkingProcessesGridControl = new DevExpress.XtraGrid.GridControl();
            this.ItemForWorkingProcesses = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatusCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.MetaKeywordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForMetaKeyword = new DevExpress.XtraLayout.LayoutControlItem();
            this.MetaDescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForMetaDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingProcessesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkingProcesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetaKeywordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMetaKeyword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetaDescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMetaDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLNS.UI.ViewModels.PositionViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLNS.UI.ViewModels.PositionViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLNS.UI.ViewModels.PositionViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLNS.UI.ViewModels.PositionViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLNS.UI.ViewModels.PositionViewModel), "SaveLayout", this.bbiSaveLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLNS.UI.ViewModels.PositionViewModel), "ResetLayout", this.bbiResetLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLNS.UI.ViewModels.PositionViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(QLNS.UI.ViewModels.PositionViewModel), "Close", this.bbiClose)});
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(QLNS.UI.ViewModels.PositionViewModel);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiSaveLayout,
            this.bbiResetLayout,
            this.bbiDelete,
            this.bbiClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(600, 141);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmployeesGridControl);
            this.dataLayoutControl1.Controls.Add(this.WorkingProcessesGridControl);
            this.dataLayoutControl1.Controls.Add(this.StatusCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.MetaKeywordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MetaDescriptionTextEdit);
            this.dataLayoutControl1.DataSource = this.positionBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForWorkingProcesses,
            this.ItemForEmployees,
            this.ItemForMetaKeyword,
            this.ItemForMetaDescription});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 141);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(600, 195);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(600, 195);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataSource = typeof(QLNS.Model.Models.Position);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 1;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndClose);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveLayout);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiResetLayout);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "SaveAndClose";
            this.bbiSaveAndClose.Id = 2;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "SaveAndNew";
            this.bbiSaveAndNew.Id = 3;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 4;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiSaveLayout
            // 
            this.bbiSaveLayout.Caption = "Save Layout";
            this.bbiSaveLayout.Id = 5;
            this.bbiSaveLayout.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSaveLayout.Name = "bbiSaveLayout";
            // 
            // bbiResetLayout
            // 
            this.bbiResetLayout.Caption = "Reset Layout";
            this.bbiResetLayout.Id = 6;
            this.bbiResetLayout.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiResetLayout.Name = "bbiResetLayout";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 7;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 8;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForStatus});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(580, 175);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.positionBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameTextEdit.Location = new System.Drawing.Point(43, 12);
            this.NameTextEdit.MenuManager = this.ribbonControl1;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.NameTextEdit.Size = new System.Drawing.Size(545, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 4;
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(580, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(27, 13);
            // 
            // EmployeesGridControl
            // 
            this.EmployeesGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.positionBindingSource, "Employees", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EmployeesGridControl.Location = new System.Drawing.Point(12, 36);
            this.EmployeesGridControl.MainView = this.gridView1;
            this.EmployeesGridControl.MenuManager = this.ribbonControl1;
            this.EmployeesGridControl.Name = "EmployeesGridControl";
            this.EmployeesGridControl.Size = new System.Drawing.Size(576, 76);
            this.EmployeesGridControl.TabIndex = 5;
            this.EmployeesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ItemForEmployees
            // 
            this.ItemForEmployees.Control = this.EmployeesGridControl;
            this.ItemForEmployees.Location = new System.Drawing.Point(0, 24);
            this.ItemForEmployees.Name = "ItemForEmployees";
            this.ItemForEmployees.Size = new System.Drawing.Size(580, 80);
            this.ItemForEmployees.StartNewLine = true;
            this.ItemForEmployees.Text = "Employees";
            this.ItemForEmployees.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForEmployees.TextVisible = false;
            // 
            // WorkingProcessesGridControl
            // 
            this.WorkingProcessesGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.positionBindingSource, "WorkingProcesses", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.WorkingProcessesGridControl.Location = new System.Drawing.Point(12, 66);
            this.WorkingProcessesGridControl.MainView = this.gridView2;
            this.WorkingProcessesGridControl.MenuManager = this.ribbonControl1;
            this.WorkingProcessesGridControl.Name = "WorkingProcessesGridControl";
            this.WorkingProcessesGridControl.Size = new System.Drawing.Size(576, 46);
            this.WorkingProcessesGridControl.TabIndex = 6;
            this.WorkingProcessesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // ItemForWorkingProcesses
            // 
            this.ItemForWorkingProcesses.Control = this.WorkingProcessesGridControl;
            this.ItemForWorkingProcesses.Location = new System.Drawing.Point(0, 56);
            this.ItemForWorkingProcesses.Name = "ItemForWorkingProcesses";
            this.ItemForWorkingProcesses.Size = new System.Drawing.Size(580, 50);
            this.ItemForWorkingProcesses.StartNewLine = true;
            this.ItemForWorkingProcesses.Text = "Working Processes";
            this.ItemForWorkingProcesses.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForWorkingProcesses.TextVisible = false;
            // 
            // StatusCheckEdit
            // 
            this.StatusCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.positionBindingSource, "Status", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StatusCheckEdit.Location = new System.Drawing.Point(12, 36);
            this.StatusCheckEdit.MenuManager = this.ribbonControl1;
            this.StatusCheckEdit.Name = "StatusCheckEdit";
            this.StatusCheckEdit.Properties.Caption = "Active";
            this.StatusCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.StatusCheckEdit.Size = new System.Drawing.Size(576, 19);
            this.StatusCheckEdit.StyleController = this.dataLayoutControl1;
            this.StatusCheckEdit.TabIndex = 7;
            // 
            // ItemForStatus
            // 
            this.ItemForStatus.Control = this.StatusCheckEdit;
            this.ItemForStatus.Location = new System.Drawing.Point(0, 24);
            this.ItemForStatus.Name = "ItemForStatus";
            this.ItemForStatus.Size = new System.Drawing.Size(580, 151);
            this.ItemForStatus.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForStatus.TextVisible = false;
            // 
            // MetaKeywordTextEdit
            // 
            this.MetaKeywordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.positionBindingSource, "MetaKeyword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MetaKeywordTextEdit.Location = new System.Drawing.Point(96, 139);
            this.MetaKeywordTextEdit.MenuManager = this.ribbonControl1;
            this.MetaKeywordTextEdit.Name = "MetaKeywordTextEdit";
            this.MetaKeywordTextEdit.Size = new System.Drawing.Size(492, 20);
            this.MetaKeywordTextEdit.StyleController = this.dataLayoutControl1;
            this.MetaKeywordTextEdit.TabIndex = 8;
            // 
            // ItemForMetaKeyword
            // 
            this.ItemForMetaKeyword.Control = this.MetaKeywordTextEdit;
            this.ItemForMetaKeyword.Location = new System.Drawing.Point(0, 127);
            this.ItemForMetaKeyword.Name = "ItemForMetaKeyword";
            this.ItemForMetaKeyword.Size = new System.Drawing.Size(580, 24);
            this.ItemForMetaKeyword.Text = "Meta Keyword";
            this.ItemForMetaKeyword.TextSize = new System.Drawing.Size(50, 20);
            // 
            // MetaDescriptionTextEdit
            // 
            this.MetaDescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.positionBindingSource, "MetaDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MetaDescriptionTextEdit.Location = new System.Drawing.Point(96, 163);
            this.MetaDescriptionTextEdit.MenuManager = this.ribbonControl1;
            this.MetaDescriptionTextEdit.Name = "MetaDescriptionTextEdit";
            this.MetaDescriptionTextEdit.Size = new System.Drawing.Size(492, 20);
            this.MetaDescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.MetaDescriptionTextEdit.TabIndex = 9;
            // 
            // ItemForMetaDescription
            // 
            this.ItemForMetaDescription.Control = this.MetaDescriptionTextEdit;
            this.ItemForMetaDescription.Location = new System.Drawing.Point(0, 127);
            this.ItemForMetaDescription.Name = "ItemForMetaDescription";
            this.ItemForMetaDescription.Size = new System.Drawing.Size(580, 48);
            this.ItemForMetaDescription.Text = "Meta Description";
            this.ItemForMetaDescription.TextSize = new System.Drawing.Size(50, 20);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.EmployeesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.WorkingProcessesGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // PositionsEditFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "PositionsEditFormView";
            this.Size = new System.Drawing.Size(600, 336);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingProcessesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkingProcesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetaKeywordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMetaKeyword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetaDescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMetaDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;
        private DevExpress.XtraBars.BarButtonItem bbiResetLayout;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl EmployeesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl WorkingProcessesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.CheckEdit StatusCheckEdit;
        private DevExpress.XtraEditors.TextEdit MetaKeywordTextEdit;
        private DevExpress.XtraEditors.TextEdit MetaDescriptionTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWorkingProcesses;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployees;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMetaKeyword;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMetaDescription;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
    }
}
