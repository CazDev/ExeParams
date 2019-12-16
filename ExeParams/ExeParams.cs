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
        
        static void Main(string[] args)
        {
            //Start process with arguments.
            System.Diagnostics.Process.Start(args[0], args[1], args[2], args[3]);
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            //Start process using directory and params from GUI
            try
            {
                System.Diagnostics.Process.Start(txtExe.Text, txtParams.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (chkClose.Checked)
            {
                this.Close();
                Environment.Exit(0);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            //File browser to select .exe
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFD.FileName);
                    txtExe.Text = openFD.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
