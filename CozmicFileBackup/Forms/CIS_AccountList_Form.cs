using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Columns;

namespace CozmicFileBackup.Forms
{
    public partial class CIS_AccountList_Form : CIS_Base_Form
    {
        public CIS_AccountList_Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// btnAccept_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnAccept_Click(object sender, EventArgs e)
        {
        }


        /// <summary>
        ///       btnClose_Click  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// SetData
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        public void SetData<T>(List<T> data)
        {
            this.CIS_DataList.SetData(data);
            this.FormatGrid();
        }

        void FormatGrid()
        {
            foreach (GridColumn col in this.CIS_DataList.DataListView.Columns)
            {
                if (col.Name.Contains("ID")) col.VisibleIndex = -1;
                col.OptionsColumn.AllowEdit = false;
            }
        }

        /// <summary>
        /// SetData
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        public void SetData<T>(T data)
        {
            var list = new List<T>() { data };
            this.CIS_DataList.SetData(list);
            this.FormatGrid();
        }
    }
}