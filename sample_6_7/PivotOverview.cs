using DevExpress.XtraEditors;

namespace sample_6_7 {
  public partial class PivotOverview : XtraUserControl {
    public PivotOverview() {
      InitializeComponent();
    }

    private void printExportItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
      Program.MainForm.ShowPrintPreview("Pivot Overview", pivotGridControl1);
    }
  }
}