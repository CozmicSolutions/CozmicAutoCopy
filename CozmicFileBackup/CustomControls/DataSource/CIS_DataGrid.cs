using System.Collections.Generic;

namespace CozmicFileBackup.CustomControls
{
    using System;

    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Views.Grid;

    public partial class CIS_DataGrid : DevExpress.XtraEditors.XtraUserControl
    {
        public CIS_DataGrid()
        {
            this.InitializeComponent();
        }

        public GridControl DataListControl => this.gridControl;

        public GridView DataListView => this.gridView;

        public virtual void DoubleClick(object sender, EventArgs e)
        {
        }

        public List<T> GetData<T>()
        {
            return (List<T>)this.gridControl.DataSource;
        }

        public void SetData<T>(List<T> dataList)
        {
            this.gridControl.DataSource = null;
            this.gridControl.DataSource = dataList;
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.DoubleClick(sender, e);
        }
    }
}