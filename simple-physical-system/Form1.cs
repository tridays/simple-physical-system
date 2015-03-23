using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_physical_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vector v1 = new Vector(3, 0);
            Vector v2 = new Vector(4, (Math.PI / 2));
            Vector v = v1 - v2;
            MessageBox.Show(v.length.ToString() + "\n" + v.degree.ToString());
            this.Dispose();
        }
    }
}
