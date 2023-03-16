using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBox_Evento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";

            if (checkBoxFla.Checked)
            {
                txt += checkBoxFla.Text + ",";
             }

            if (checkBoxPal.Checked) 
            {
                txt += checkBoxPal.Text + ",";
            }

            if (checkBoxCor.Checked)
            {
                txt += checkBoxCor.Text + ",";
            }

            if (checkBoxSao.Checked)
            {
                txt += checkBoxSao.Text + ",";
            }

            if (checkBoxSan.Checked) 
            {
                txt += checkBoxSan.Text + ",";
            }
            if (checkBoxFlu.Checked)
            {
            txt = checkBoxFlu.Text + ",";
            }
            MessageBox.Show("O Time escolhido foi: " + txt, "O Time escolhido...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
