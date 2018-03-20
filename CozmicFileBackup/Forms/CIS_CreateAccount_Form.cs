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
    using DevExpress.XtraEditors.DXErrorProvider;

    public partial class CIS_CreateAccount_Form : CIS_Base_Form
    {
        public CIS_CreateAccount_Form()
        {
            InitializeComponent();
        }

        void ValidateControls()
        {
            if (string.IsNullOrEmpty(this.input_Username.TextStringValue))
            {
                this.dxErrorProvider.SetError(this.input_Username,"Invalid Entry",ErrorType.Warning);
                this.dxErrorProvider.SetError(this.input_Username.CaptionControl, "Invalid Entry", ErrorType.Warning);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.ValidateControls();
        }
    }
}