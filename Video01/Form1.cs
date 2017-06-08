using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video01
{
    
    public partial class Form1 : Form
    {
        int n = 0;
        public Form1()
        {
            InitializeComponent();
            Assunto.Visible = false;
            fontes.Visible = false;
            explicar.Visible = false;
            simplifica.Visible = false;
            pictureBox1.Visible = false;
        }
               
        private void Proximo_Click(object sender, EventArgs e)
        {
            n++;
            switch (n)
            {
                case 0:
                    Assunto.Visible = false;
                    fontes.Visible = false;
                    explicar.Visible = false;
                    simplifica.Visible = false;
                    pictureBox1.Visible = false;
                    break;
                case 1:
                    Assunto.Visible = true;
                    fontes.Visible = false;
                    explicar.Visible = false;
                    simplifica.Visible = false;
                    pictureBox1.Visible = false;
                    break;
                case 2:
                    Assunto.Visible = true;
                    fontes.Visible = true;
                    explicar.Visible = false;
                    simplifica.Visible = false;
                    pictureBox1.Visible = false;
                    break;
                case 3:
                    Assunto.Visible = true;
                    fontes.Visible = true;
                    explicar.Visible = true;
                    simplifica.Visible = false;
                    pictureBox1.Visible = false;
                    break;
                case 4:
                    Assunto.Visible = true;
                    fontes.Visible = true;
                    explicar.Visible = true;
                    simplifica.Visible = true;
                    pictureBox1.Visible = false;
                    break;
                case 5:
                    Assunto.Visible = true;
                    fontes.Visible = true;
                    explicar.Visible = true;
                    simplifica.Visible = true;
                    pictureBox1.Visible = true;
                    break;
            }
        }
    }
}
