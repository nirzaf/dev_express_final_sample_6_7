namespace sample_6_7 {
  partial class CustomerList {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
      DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
      this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
      this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.grid = new DevExpress.XtraGrid.GridControl();
      this.customerCollection = new DevExpress.Xpo.XPCollection(this.components);
      this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
      this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
      this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
      this.layoutViewField_colLine1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
      this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
      this.layoutViewField_colLine2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
      this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
      this.layoutViewField_colLine3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
      this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
      this.layoutViewField_colCity = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
      this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
      this.layoutViewField_colPostCode = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
      this.layoutViewColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
      this.layoutViewField_colCountry = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
      this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
      this.customerView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.invoiceContactColumn = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.saveChangesItem = new DevExpress.XtraBars.BarButtonItem();
      this.discardChangesItem = new DevExpress.XtraBars.BarButtonItem();
      this.printExportItem = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.invoiceContactLookupEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
      this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPhoneNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.addressView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colLine1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colLine2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colLine3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPostCode = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
      this.contactView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
      this.contactCollection = new DevExpress.Xpo.XPCollection(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLine1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLine2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLine3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCity)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPostCode)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCountry)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.invoiceContactLookupEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.contactView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.contactCollection)).BeginInit();
      this.SuspendLayout();
      // 
      // cardView1
      // 
      this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4});
      this.cardView1.GridControl = this.grid;
      this.cardView1.Name = "cardView1";
      this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
      this.cardView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.view_InvalidRowException);
      this.cardView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.view_ValidateRow);
      // 
      // gridColumn2
      // 
      this.gridColumn2.FieldName = "Name";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      // 
      // gridColumn4
      // 
      this.gridColumn4.FieldName = "PhoneNumber";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 1;
      // 
      // grid
      // 
      this.grid.DataSource = this.customerCollection;
      this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
      gridLevelNode1.LevelTemplate = this.cardView1;
      gridLevelNode1.RelationName = "Contacts";
      gridLevelNode2.LevelTemplate = this.layoutView1;
      gridLevelNode2.RelationName = "Addresses";
      this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
      this.grid.Location = new System.Drawing.Point(0, 150);
      this.grid.MainView = this.customerView;
      this.grid.MenuManager = this.ribbonControl1;
      this.grid.Name = "grid";
      this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.invoiceContactLookupEdit});
      this.grid.ShowOnlyPredefinedDetails = true;
      this.grid.Size = new System.Drawing.Size(816, 422);
      this.grid.TabIndex = 1;
      this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.customerView,
            this.addressView,
            this.contactView,
            this.cardView1});
      // 
      // customerCollection
      // 
      this.customerCollection.ObjectType = typeof(EventsDB.Customer);
      this.customerCollection.Session = this.unitOfWork;
      // 
      // layoutView1
      // 
      this.layoutView1.CardMinSize = new System.Drawing.Size(320, 126);
      this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4,
            this.layoutViewColumn5,
            this.layoutViewColumn6});
      this.layoutView1.GridControl = this.grid;
      this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colCountry});
      this.layoutView1.Name = "layoutView1";
      this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
      this.layoutView1.TemplateCard = this.layoutViewCard1;
      this.layoutView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.view_InvalidRowException);
      this.layoutView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.view_ValidateRow);
      // 
      // layoutViewColumn1
      // 
      this.layoutViewColumn1.FieldName = "Line1";
      this.layoutViewColumn1.LayoutViewField = this.layoutViewField_colLine1;
      this.layoutViewColumn1.Name = "layoutViewColumn1";
      // 
      // layoutViewField_colLine1
      // 
      this.layoutViewField_colLine1.EditorPreferredWidth = 93;
      this.layoutViewField_colLine1.Location = new System.Drawing.Point(0, 0);
      this.layoutViewField_colLine1.Name = "layoutViewField_colLine1";
      this.layoutViewField_colLine1.Size = new System.Drawing.Size(156, 24);
      this.layoutViewField_colLine1.TextSize = new System.Drawing.Size(53, 13);
      // 
      // layoutViewColumn2
      // 
      this.layoutViewColumn2.FieldName = "Line2";
      this.layoutViewColumn2.LayoutViewField = this.layoutViewField_colLine2;
      this.layoutViewColumn2.Name = "layoutViewColumn2";
      // 
      // layoutViewField_colLine2
      // 
      this.layoutViewField_colLine2.EditorPreferredWidth = 93;
      this.layoutViewField_colLine2.Location = new System.Drawing.Point(0, 24);
      this.layoutViewField_colLine2.Name = "layoutViewField_colLine2";
      this.layoutViewField_colLine2.Size = new System.Drawing.Size(156, 24);
      this.layoutViewField_colLine2.TextSize = new System.Drawing.Size(53, 13);
      // 
      // layoutViewColumn3
      // 
      this.layoutViewColumn3.FieldName = "Line3";
      this.layoutViewColumn3.LayoutViewField = this.layoutViewField_colLine3;
      this.layoutViewColumn3.Name = "layoutViewColumn3";
      // 
      // layoutViewField_colLine3
      // 
      this.layoutViewField_colLine3.EditorPreferredWidth = 93;
      this.layoutViewField_colLine3.Location = new System.Drawing.Point(0, 48);
      this.layoutViewField_colLine3.Name = "layoutViewField_colLine3";
      this.layoutViewField_colLine3.Size = new System.Drawing.Size(156, 37);
      this.layoutViewField_colLine3.TextSize = new System.Drawing.Size(53, 13);
      // 
      // layoutViewColumn4
      // 
      this.layoutViewColumn4.FieldName = "City";
      this.layoutViewColumn4.LayoutViewField = this.layoutViewField_colCity;
      this.layoutViewColumn4.Name = "layoutViewColumn4";
      // 
      // layoutViewField_colCity
      // 
      this.layoutViewField_colCity.EditorPreferredWidth = 83;
      this.layoutViewField_colCity.Location = new System.Drawing.Point(156, 0);
      this.layoutViewField_colCity.Name = "layoutViewField_colCity";
      this.layoutViewField_colCity.Size = new System.Drawing.Size(146, 24);
      this.layoutViewField_colCity.TextSize = new System.Drawing.Size(53, 13);
      // 
      // layoutViewColumn5
      // 
      this.layoutViewColumn5.FieldName = "PostCode";
      this.layoutViewColumn5.LayoutViewField = this.layoutViewField_colPostCode;
      this.layoutViewColumn5.Name = "layoutViewColumn5";
      // 
      // layoutViewField_colPostCode
      // 
      this.layoutViewField_colPostCode.EditorPreferredWidth = 83;
      this.layoutViewField_colPostCode.Location = new System.Drawing.Point(156, 24);
      this.layoutViewField_colPostCode.Name = "layoutViewField_colPostCode";
      this.layoutViewField_colPostCode.Size = new System.Drawing.Size(146, 61);
      this.layoutViewField_colPostCode.TextSize = new System.Drawing.Size(53, 13);
      // 
      // layoutViewColumn6
      // 
      this.layoutViewColumn6.FieldName = "Country";
      this.layoutViewColumn6.LayoutViewField = this.layoutViewField_colCountry;
      this.layoutViewColumn6.Name = "layoutViewColumn6";
      // 
      // layoutViewField_colCountry
      // 
      this.layoutViewField_colCountry.EditorPreferredWidth = 20;
      this.layoutViewField_colCountry.Location = new System.Drawing.Point(0, 0);
      this.layoutViewField_colCountry.Name = "layoutViewField_colCountry";
      this.layoutViewField_colCountry.Size = new System.Drawing.Size(302, 85);
      this.layoutViewField_colCountry.TextSize = new System.Drawing.Size(53, 13);
      // 
      // layoutViewCard1
      // 
      this.layoutViewCard1.CustomizationFormText = "TemplateCard";
      this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
      this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colLine1,
            this.layoutViewField_colLine2,
            this.layoutViewField_colLine3,
            this.layoutViewField_colCity,
            this.layoutViewField_colPostCode});
      this.layoutViewCard1.Name = "layoutViewCard1";
      this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
      this.layoutViewCard1.Text = "TemplateCard";
      // 
      // customerView
      // 
      this.customerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.invoiceContactColumn,
            this.gridColumn3});
      this.customerView.GridControl = this.grid;
      this.customerView.Name = "customerView";
      this.customerView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.invoiceContactColumn, DevExpress.Data.ColumnSortOrder.Descending)});
      this.customerView.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.customerView_CustomRowCellEditForEditing);
      this.customerView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.view_InvalidRowException);
      this.customerView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.view_ValidateRow);
      this.customerView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.customerView_CustomColumnDisplayText);
      this.customerView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.customerView_ValidatingEditor);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // invoiceContactColumn
      // 
      this.invoiceContactColumn.FieldName = "InvoiceContact!";
      this.invoiceContactColumn.Name = "invoiceContactColumn";
      this.invoiceContactColumn.Visible = true;
      this.invoiceContactColumn.VisibleIndex = 1;
      // 
      // gridColumn3
      // 
      this.gridColumn3.FieldName = "InvoiceAddress!";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 2;
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.saveChangesItem,
            this.discardChangesItem,
            this.printExportItem});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 1;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
      this.ribbonControl1.Size = new System.Drawing.Size(816, 150);
      // 
      // saveChangesItem
      // 
      this.saveChangesItem.Caption = "Save Changes";
      this.saveChangesItem.Id = 1;
      this.saveChangesItem.ImageOptions.SvgImage = global::sample_6_7.Properties.Resources.savechanges;
      this.saveChangesItem.Name = "saveChangesItem";
      // 
      // discardChangesItem
      // 
      this.discardChangesItem.Caption = "Discard Changes";
      this.discardChangesItem.Id = 2;
      this.discardChangesItem.ImageOptions.SvgImage = global::sample_6_7.Properties.Resources.discardchanges;
      this.discardChangesItem.Name = "discardChangesItem";
      // 
      // printExportItem
      // 
      this.printExportItem.Caption = "Print && Export";
      this.printExportItem.Id = 3;
      this.printExportItem.ImageOptions.SvgImage = global::sample_6_7.Properties.Resources.printexport;
      this.printExportItem.Name = "printExportItem";
      this.printExportItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printExportItem_ItemClick);
      // 
      // ribbonPageCategory1
      // 
      this.ribbonPageCategory1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.ribbonPageCategory1.Appearance.Options.UseBackColor = true;
      this.ribbonPageCategory1.Name = "ribbonPageCategory1";
      this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbonPageCategory1.Text = "Customers";
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "Data Operations";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.saveChangesItem);
      this.ribbonPageGroup1.ItemLinks.Add(this.discardChangesItem);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "Persistence";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.ItemLinks.Add(this.printExportItem);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "Tools";
      // 
      // invoiceContactLookupEdit
      // 
      this.invoiceContactLookupEdit.AutoHeight = false;
      this.invoiceContactLookupEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.invoiceContactLookupEdit.Name = "invoiceContactLookupEdit";
      this.invoiceContactLookupEdit.PopupView = this.repositoryItemGridLookUpEdit1View;
      // 
      // repositoryItemGridLookUpEdit1View
      // 
      this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName2,
            this.colPhoneNumber1});
      this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
      this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      // 
      // colName2
      // 
      this.colName2.FieldName = "Name";
      this.colName2.Name = "colName2";
      this.colName2.Visible = true;
      this.colName2.VisibleIndex = 0;
      // 
      // colPhoneNumber1
      // 
      this.colPhoneNumber1.FieldName = "PhoneNumber";
      this.colPhoneNumber1.Name = "colPhoneNumber1";
      this.colPhoneNumber1.Visible = true;
      this.colPhoneNumber1.VisibleIndex = 1;
      // 
      // addressView
      // 
      this.addressView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLine1,
            this.colLine2,
            this.colLine3,
            this.colCity,
            this.colPostCode,
            this.colCountry});
      this.addressView.GridControl = this.grid;
      this.addressView.Name = "addressView";
      // 
      // colLine1
      // 
      this.colLine1.FieldName = "Line1";
      this.colLine1.Name = "colLine1";
      this.colLine1.Visible = true;
      this.colLine1.VisibleIndex = 0;
      // 
      // colLine2
      // 
      this.colLine2.FieldName = "Line2";
      this.colLine2.Name = "colLine2";
      this.colLine2.Visible = true;
      this.colLine2.VisibleIndex = 1;
      // 
      // colLine3
      // 
      this.colLine3.FieldName = "Line3";
      this.colLine3.Name = "colLine3";
      this.colLine3.Visible = true;
      this.colLine3.VisibleIndex = 2;
      // 
      // colCity
      // 
      this.colCity.FieldName = "City";
      this.colCity.Name = "colCity";
      this.colCity.Visible = true;
      this.colCity.VisibleIndex = 4;
      // 
      // colPostCode
      // 
      this.colPostCode.FieldName = "PostCode";
      this.colPostCode.Name = "colPostCode";
      this.colPostCode.Visible = true;
      this.colPostCode.VisibleIndex = 3;
      // 
      // colCountry
      // 
      this.colCountry.FieldName = "Country";
      this.colCountry.Name = "colCountry";
      this.colCountry.Visible = true;
      this.colCountry.VisibleIndex = 5;
      // 
      // contactView
      // 
      this.contactView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colPhoneNumber});
      this.contactView.GridControl = this.grid;
      this.contactView.Name = "contactView";
      // 
      // colName1
      // 
      this.colName1.FieldName = "Name";
      this.colName1.Name = "colName1";
      this.colName1.Visible = true;
      this.colName1.VisibleIndex = 0;
      // 
      // colPhoneNumber
      // 
      this.colPhoneNumber.FieldName = "PhoneNumber";
      this.colPhoneNumber.Name = "colPhoneNumber";
      this.colPhoneNumber.Visible = true;
      this.colPhoneNumber.VisibleIndex = 1;
      // 
      // contactCollection
      // 
      this.contactCollection.ObjectType = typeof(EventsDB.CustomerContact);
      this.contactCollection.Session = this.unitOfWork;
      // 
      // CustomerList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.grid);
      this.Controls.Add(this.ribbonControl1);
      this.Name = "CustomerList";
      this.Size = new System.Drawing.Size(816, 572);
      this.Load += new System.EventHandler(this.CustomerList_Load);
      ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLine1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLine2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLine3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCity)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPostCode)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCountry)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.invoiceContactLookupEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.contactView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.contactCollection)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private DevExpress.Xpo.UnitOfWork unitOfWork;
    private DevExpress.Xpo.XPCollection customerCollection;
    private DevExpress.XtraBars.BarButtonItem saveChangesItem;
    private DevExpress.XtraBars.BarButtonItem discardChangesItem;
    private DevExpress.XtraBars.BarButtonItem printExportItem;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
    private DevExpress.XtraGrid.GridControl grid;
    private DevExpress.XtraGrid.Views.Grid.GridView customerView;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn invoiceContactColumn;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    private DevExpress.XtraGrid.Views.Grid.GridView contactView;
    private DevExpress.XtraGrid.Views.Grid.GridView addressView;
    private DevExpress.XtraGrid.Columns.GridColumn colName1;
    private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
    private DevExpress.XtraGrid.Columns.GridColumn colLine1;
    private DevExpress.XtraGrid.Columns.GridColumn colLine2;
    private DevExpress.XtraGrid.Columns.GridColumn colLine3;
    private DevExpress.XtraGrid.Columns.GridColumn colCity;
    private DevExpress.XtraGrid.Columns.GridColumn colPostCode;
    private DevExpress.XtraGrid.Columns.GridColumn colCountry;
    private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
    private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
    private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colLine1;
    private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
    private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colLine2;
    private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
    private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colLine3;
    private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
    private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCity;
    private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
    private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPostCode;
    private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn6;
    private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCountry;
    private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit invoiceContactLookupEdit;
    private DevExpress.Xpo.XPCollection contactCollection;
    private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
    private DevExpress.XtraGrid.Columns.GridColumn colName2;
    private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber1;
  }
}