using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_de_Avaliaçao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        iphone telemovel = new iphone();
        private void click(object sender, EventArgs e)
        {

        }

        private void clicar(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }
    }
}
