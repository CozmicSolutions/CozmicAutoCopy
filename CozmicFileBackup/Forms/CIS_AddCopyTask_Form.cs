using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CozmicFileBackup.Forms
{
    using CozmicBackupDataAccess;

    using CozmicFileBackup.CustomControls;

    using DevExpress.XtraEditors.DXErrorProvider;

    public partial class CIS_AddCopyTask_Form : CIS_Base_Form
    {
        public CIS_AddCopyTask_Form()
        {
            this.InitializeComponent();
            this.BrowsePath_Source.SetBrowseType(BrowseType.Folder);
            this.BrowsePath_Source.SetCaption("Source Path");
        }

        /// <summary>
        ///       btnClose_Click  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}