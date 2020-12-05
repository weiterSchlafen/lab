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
    public partial class Form1 : Form
    {
        static private Form1 form = new Form1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbstractFactory factory1 = new Drevolaz();
            Client c = new Client(factory1);
            c.Run();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AbstractFactory factory1 = new Vodonos();
            Client c = new Client(factory1);
            c.Run();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laba5Library.Class1.Text());
        }
    }
}
