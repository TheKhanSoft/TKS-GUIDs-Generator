using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKS.Tools;

namespace TKS_Guid_Generator
{
    public partial class TKSGuidGenerator : TKSOrangeForm
    {
        public TKSGuidGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerateGuids_Click(object sender, EventArgs e)
        {
            int generateCount = int.Parse(txtGuidsCount.Text);
            string guids = string.Empty;
            if (generateCount > 0)
            {
                bool hyphens = chkHyphens.Checked;
                bool braces = chkBraces.Checked;
                bool upperCase = chkUppercase.Checked;
                
                txtGuids.Text = string.Empty;
                
                for (int i = 0; i < generateCount; i++)
                {
                    string guid = Guid.NewGuid().ToString();
                    string newLine = "\r\n";
                    if (i == generateCount - 1)
                    {
                        newLine = string.Empty;
                    }
                    if (!hyphens)
                    {
                        guid = guid.Replace("-", string.Empty);
                    }
                    if (braces)
                    {
                        guid = "{"+ guid + "}";
                    }
                    if (upperCase)
                    {
                        guid = guid.ToUpper();
                    }
                    guids = guids + guid + newLine;
                }
                txtGuids.Text = guids.ToString();
            }
            
        }

        private void btnCopyGuids_Click(object sender, EventArgs e)
        {
            txtGuids.SelectAll();
            txtGuids.Copy();
            MessageBox.Show(txtGuids.Lines.Count() + " GUIDs copied to clipboad!");
        }

        private void txtGuids_TextChanged(object sender, EventArgs e)
        {
            gBoxGuids.Text = "[" + txtGuids.Lines.Count() + "]";
        }
    }
}
