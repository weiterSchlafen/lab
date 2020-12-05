using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    public partial class drevolazForm : Form
    {
        private PropertiesDrevolaz propDrevolaz;
        public drevolazForm(AbstractProperties abstractProperties)
        {
            propDrevolaz = (PropertiesDrevolaz)abstractProperties;
            InitializeComponent();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = propDrevolaz.madeProperties();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
    }
}
