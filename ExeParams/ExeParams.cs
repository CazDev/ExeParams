using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeParams
{
    public partial class ExeParams : Form
    {
        public ExeParams()
        {
            InitializeComponent();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txtExe.Text, txtParams.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (chkClose.Checked)
            {
                this.Close();
                Environment.Exit(0);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFD.FileName);
                    txtExe.Text = openFD.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
