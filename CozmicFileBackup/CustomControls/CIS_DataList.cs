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

namespace CozmicFileBackup.CustomControls
{
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Views.Grid;

    public partial class CIS_DataList : DevExpress.XtraEditors.XtraUserControl
    {
        public GridView DataListView {get
            {
                return this.gridView;
            } }

        public GridControl DataListControl
        {
            get
            {
                return this.gridControl;
            }
        }

        public CIS_DataList()
        {
            this.InitializeComponent();
        }

        public void SetData<T>(List<T> dataList)
        {
            this.gridControl.DataSource = null;
            this.gridControl.DataSource = dataList;
        }

        public List<T> GetData<T>( )
        {
            
            return (List <T>)this.gridControl.DataSource;
        }
    }
}
