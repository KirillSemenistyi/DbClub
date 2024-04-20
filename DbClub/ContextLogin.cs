using DbClub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbClub
{
    public partial class ContextLogin : Form
    {
        bool flagEye = false;
        public ContextLogin()
        {
            InitializeComponent();
        }

        private void butEye_Click(object sender, EventArgs e)
        {
            flagEye = !flagEye;
            if (flagEye)
            {
                butEye.BackgroundImage = Resources.Visible;
                textBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                butEye.BackgroundImage = Resources.invisible1;
                textBoxPass.UseSystemPasswordChar = true;
            }
        }
    }
}
