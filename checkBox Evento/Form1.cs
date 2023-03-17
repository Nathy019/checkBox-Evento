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
        //criando uma lista para a utilização de um laço de repetição sendo algo um pouco mais pratico

        List <CheckBox> Time = new List <CheckBox> ();
        public Form1()
        {
            //Adicionar itens para puxar componentes mais rápidos

            InitializeComponent();
            Time.Add(checkBoxFla);
            Time.Add(checkBoxSao);
            Time.Add(checkBoxBH);
            Time.Add(checkBoxCea);
            Time.Add(checkBoxSan);
            Time.Add(checkBoxInt);
            Time.Add(checkBoxVas);
            Time.Add(checkBoxBra);
            Time.Add(checkBoxPal);
            Time.Add(checkBoxCor);
            Time.Add(checkBoxAtl);
            Time.Add(checkBoxSpo);          
            Time.Add(checkBoxGre);
            Time.Add(checkBoxFor);
            Time.Add(checkBoxFlu);
            Time.Add(checkBoxTiba);              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txt = "";

            // t = todos itens clicados
            //foreach para algum progama mais longos

            foreach (CheckBox t in Time)
            {
                if (t.Checked)
                {
                    txt += t.Text + ",";
                }
                MessageBox.Show("O Time escolhido foi: " + txt, "O Time escolhido...");

                //Funçao utilizada dentro do botão "clique aqui" usando função if para reprezentar um laço mais complexo e mostrando todo o objeto selecionado

                //    if (checkBoxFla.Checked)
                //    {
                //        txt += checkBoxFla.Text + ",";
                //     }

                //    if (checkBoxPal.Checked) 
                //    {
                //        txt += checkBoxPal.Text + ",";
                //    }

                //    if (checkBoxCor.Checked)
                //    {
                //        txt += checkBoxCor.Text + ",";
                //    }

                //    if (checkBoxSao.Checked)
                //    {
                //        txt += checkBoxSao.Text + ",";
                //    }

                //    if (checkBoxSan.Checked) 
                //    {
                //        txt += checkBoxSan.Text + ",";
                //    }
                //    if (checkBoxFlu.Checked)
                //    {
                //    txt += checkBoxFlu.Text + ",";
                //    }


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //função usadas para cada botão de intens ao clicar na seleção do objeto aparece a mensagem usando a parte if ainda, porem apenas uma em cada botão.

        private void checkBoxFla_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxFla.Checked)
            //{
            //    MessageBox.Show("O item Flamengo foi marcado");
            //}
        }

        private void checkBoxPal_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxPal.Checked)
            //{
            //    MessageBox.Show("O item Palmeiras foi marcado");
            //}
        }

        private void checkBoxCor_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxCor.Checked)
            //{
            //    MessageBox.Show("O item Corinthians foi marcado");
            //}
        }

        private void checkBoxSao_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxSao.Checked)
            //{
            //    MessageBox.Show("O item São Paulo foi marcado");            
            //}
        }

        private void checkBoxSan_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxSan.Checked)
            //{
            //    MessageBox.Show("O item Santos foi marcado");
            //}
        }

        private void checkBoxFlu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFlu.Checked)
            {
                MessageBox.Show("O item Fluminense foi marcado");
            }
        }
    }
}
