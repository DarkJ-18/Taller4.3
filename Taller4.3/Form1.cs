using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            int limite = 100;
            int i;
            for (i = 0; i < limite; i++)
            {
                dataGridView1.Rows.Add(i + 1 + "  " + txtnombre.Text);
            }

        }
    }
}
