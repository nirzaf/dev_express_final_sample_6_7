using EventsDB;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using EventsDB.Populate;
using System.Text;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Linq;
using DevExpress.XtraPrinting;

namespace sample_6_7 {
  public partial class CustomerList : XtraUserControl {
    public CustomerList() {
      InitializeComponent();
    }

    private void CustomerList_Load(object sender, System.EventArgs e) {
      TransactionalChangeHandler.Hookup<Customer>(
        DocumentManager.FromControl(ParentForm).View, unitOfWork, saveChangesItem,
        discardChangesItem, customerCollection);
    }

    private void customerView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {
      //if (sender is ColumnView view) {
      //  if (view.FocusedColumn.FieldName == "Name") {
      //    //view.ActiveEditor.EditValue
      //    e.Valid = false;
      //    e.ErrorText = "Something is wrong with the value";
      //  }
      //}
    }

    private void view_ValidateRow(object sender, ValidateRowEventArgs e) {
      //if (sender is ColumnView view &&
      //  view.GetRow(e.RowHandle) is Customer customer) {
      //  // ...
      //}


      //if (e.Row is Customer customer) {
      //  if (customer.Name != "Correct Value") {
      //    e.Valid = false;
      //    //e.ErrorText = "Name doesn't have the correct value";

      //    if (sender is ColumnView view) {
      //      view.SetColumnError(colName, "Something is wrong with this name.");
      //    }
      //  }
      //}

      ValidateViewRow(sender as ColumnView, e);
    }

    private static void ValidateViewRow(ColumnView view, ValidateRowEventArgs e) {
      var checkResults = DemoDatabase.BizRulezChecker.Check("save", e.Row).ToList();
      if (checkResults.Count > 0) {
        e.Valid = false;
        if (view != null) {
          StringBuilder rowMessages = new StringBuilder();
          Dictionary<GridColumn, StringBuilder> colMessages = new Dictionary<GridColumn, StringBuilder>();
          foreach (var result in checkResults) {
            if (result.Rule.AffectedFieldNames != null && result.Rule.AffectedFieldNames.Count > 0) {
              foreach (string affectedFieldName in result.Rule.AffectedFieldNames) {
                var column = view.Columns.ColumnByFieldName(affectedFieldName);
                StringBuilder colBuilder;
                if (colMessages.ContainsKey(column)) {
                  colBuilder = colMessages[column];
                }
                else {
                  colBuilder = new StringBuilder();
                  colMessages[column] = colBuilder;
                }
                colBuilder.AppendLine(result.ErrorInfo);
              }
            }
            else {
              rowMessages.AppendLine(result.ErrorInfo);
            }
          }
          view.SetColumnError(null, rowMessages.ToString(), ErrorType.Critical);
          foreach (GridColumn column in view.Columns) {
            if (colMessages.ContainsKey(column))
              view.SetColumnError(column, colMessages[column].ToString(), ErrorType.Critical);
            else
              view.SetColumnError(column, String.Empty);
          }
        }
      }
    }

    private void view_InvalidRowException(object sender, InvalidRowExceptionEventArgs e) {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void customerView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e) {
      if (e.Column == invoiceContactColumn &&
      e.Value is CustomerContact contact) {
        e.DisplayText = contact.Name;
      }
    }

    private void customerView_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
      if (e.Column == invoiceContactColumn) {
        if (sender is ColumnView view) {
          if (view.GetRow(e.RowHandle) is Customer customer) {
            invoiceContactLookupEdit.DataSource = customer.Contacts;
            e.RepositoryItem = invoiceContactLookupEdit;
          }
        }
      }
    }

    private void printExportItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
      //grid.ShowPrintPreview();

      var ps = new PrintingSystem();
      var link = new PrintableComponentLink(ps);
      link.Component = grid;
      //link.ShowPreviewDialog();

      link.CreateDocument();
      Program.MainForm.ShowPrintPreview("Customers", ps);
    }
  }
}
