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
    public partial class ContextVisit : Form
    {
        public ContextVisit()
        {
            InitializeComponent();
        }

        private void checkBoxEnd_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.Enabled = checkBoxEnd.Checked;
        }

        private void butAddCar_Click(object sender, EventArgs e)
        {
            if (comboBoxVisitors.SelectedIndex == -1 ||
                comboBoxComp.SelectedIndex == -1)
            {
                MessageBox.Show("Поля пустые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
