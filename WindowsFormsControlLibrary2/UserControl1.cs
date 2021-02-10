using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary2
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PropiedadDeCarlos != null && PropiedadDeCarlos != "")
            {
                MessageBox.Show(PropiedadDeCarlos, "Bien!", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Click realizado", "Bien!", MessageBoxButtons.OK);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
        }
    }
}
