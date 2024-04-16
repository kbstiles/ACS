using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using ACS_KStilesM7.Properties;

namespace ACS_KStilesM7
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            //PrivateFontCollection privateFontCollection = new PrivateFontCollection();

            //var memory = IntPtr.Zero;

            //try
            //{
            //    memory = Marshal.AllocCoTaskMem(Resources.Bhel_Puri.Length);

            //    Marshal.Copy(Resources.Bhel_Puri, 0, memory, Resources.Bhel_Puri.Length);
            //    privateFontCollection.AddMemoryFont(memory, Resources.Bhel_Puri.Length);
            //}
            //finally
            //{
            //    Marshal.FreeCoTaskMem(memory);
            //}

            //lblWelcomeText.Font = new Font(privateFontCollection.Families[0], 14);
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmShop().Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpWelcome.HelpNamespace);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAbout().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Database successfully closed.");

            Application.Exit();
        }

        private void frmWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
