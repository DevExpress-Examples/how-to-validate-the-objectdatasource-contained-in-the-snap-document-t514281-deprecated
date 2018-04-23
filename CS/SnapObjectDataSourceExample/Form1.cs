using DevExpress.Snap.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.ObjectBinding;

namespace SnapObjectDataSourceExample {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        IObjectDataSourceValidationService defaultValidationService;

        public Form1() {
            InitializeComponent();

            #region #ObjectDataSourceLoadingBehavior
            snapControl1.Options.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.Prompt;
            #endregion #ObjectDataSourceLoadingBehavior

            defaultValidationService = snapControl1.GetService<IObjectDataSourceValidationService>();

            repositoryItemDocumentLoadingBehavior.Items.AddRange(typeof(DevExpress.DataAccess.DocumentLoadingBehavior).GetEnumValues());
            barComboDocumentLoadingBehavior.EditValue = snapControl1.Options.DataSourceOptions.ObjectDataSourceLoadingBehavior;

            this.barComboDocumentLoadingBehavior.EditValueChanged += new System.EventHandler(this.barComboDocumentLoadingBehavior_EditValueChanged);
            this.barCheckCustomValidationService.CheckedChanged += BarCheckCustomValidationService_CheckedChanged;
        }

        private void BarCheckCustomValidationService_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (barCheckCustomValidationService.Checked) {
                #region #ReplaceService
                snapControl1.ReplaceService<IObjectDataSourceValidationService>(new MyObjectDataSourceValidationService());
                #endregion #ReplaceService
            }
            else {
                snapControl1.ReplaceService<IObjectDataSourceValidationService>(defaultValidationService);
            }
        }

        private void barBtnLoadSnx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            snapControl1.LoadDocument("DataBoundReport.snx");
        }

        private void barComboDocumentLoadingBehavior_EditValueChanged(object sender, EventArgs e) {
            snapControl1.Options.DataSourceOptions.ObjectDataSourceLoadingBehavior = (DevExpress.DataAccess.DocumentLoadingBehavior)(sender as DevExpress.XtraBars.BarEditItem).EditValue;
        }
    }
    #region #MyObjectDataSourceValidationService
    public class MyObjectDataSourceValidationService : IObjectDataSourceValidationService {
        public void Validate(IEnumerable<ObjectDataSource> dataSources) {
            // Do nothing to allow loading.
            // Clear the DataSource and DataMember properties to prohibit loading.
            foreach (ObjectDataSource ds in dataSources) {
                ds.DataSource = null;
                ds.DataMember = null;
            };
        }
    }
    #endregion #MyObjectDataSourceValidationService
}
