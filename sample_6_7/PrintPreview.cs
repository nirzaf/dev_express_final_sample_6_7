using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;

namespace sample_6_7 {
  public partial class PrintPreview : DevExpress.XtraEditors.XtraUserControl {
    public PrintPreview() {
      InitializeComponent();
    }

    public PrintPreview(Action<PrintPreview> initAction) : this() {
      this.initAction = initAction;
    }

    Action<PrintPreview> initAction;

    void ShowDocument(Action<DocumentViewer> init) {
      this.xtraReport = null;
      init(documentViewer);
    }

    public void ShowDocument(PrintingSystemBase printingSystem) {
      InitEditButton(false);
      ShowDocument(dv => dv.DocumentSource = printingSystem);
    }

    private void documentViewer_Load(object sender, EventArgs e) {
      initAction?.Invoke(this);
    }

    XtraReport xtraReport;

    public void ShowDocument(XtraReport xtraReport) {
      InitEditButton(true);
      ShowDocument(dv => dv.DocumentSource = xtraReport);
      this.xtraReport = xtraReport;
    }

    private void editReportButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
      xtraReport.ShowDesignerDialog();
      xtraReport.CreateDocument();
    }

    void InitEditButton(bool visible) {
      editReportButton.Visibility = visible ? BarItemVisibility.Always : BarItemVisibility.Never;
    }
  }
}
