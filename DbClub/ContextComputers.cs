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
    public partial class ContextComputers : Form
    {
        public ContextComputers()
        {
            InitializeComponent();
        }

        private void butAddComp_Click(object sender, EventArgs e)
        {
            if (textBoxCompName.Text == string.Empty ||
                textBoxSpecifications.Text == string.Empty ||
                comboBoxStatus.SelectedIndex == -1) 
            {
                MessageBox.Show("Поля пустые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
