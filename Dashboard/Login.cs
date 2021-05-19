using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_COMPUTEL
{
    public partial class fmrUno : Form
    {
        public fmrUno()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void fmrUno_Load(object sender, EventArgs e)
        {

        }

        private void buttonDos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxDos_TextChanged(object sender, EventArgs e)
        {
        }
        int posY = 0;
        int posX = 0;
        private void fmrUno_MouseMove(object sender, MouseEventArgs e)
        {
        if(e.Button!= MouseButtons.Left)
        {
            posX = e.X;
            posY = e.Y;
        }
        else
        {
            Left = Left + (e.X - posX);
            Top = Top + (e.Y - posY);
        }
        
    }
    }
}



