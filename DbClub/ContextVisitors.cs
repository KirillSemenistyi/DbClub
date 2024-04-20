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
    public partial class ContextVisitors : Form
    {
        public ContextVisitors()
        {
            InitializeComponent();
        }

        private void butAddVisitor_Click(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == string.Empty || 
                textBoxName.Text == string.Empty ||
                textBoxLastname.Text == string.Empty ||
                textBoxEmail.Text == string.Empty ||
                maskedTextBoxPhoneNumber.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
