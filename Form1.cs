using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace MyApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
        }

            private void btnSomar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 + valor2;

            lblResultado.Text = resultado.ToString();
        }


        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 - valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 * valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 / valor2;

            lblResultado.Text = resultado.ToString("N2");
        }

       
        private void btnMedia_Click(object sender, EventArgs e)
        {
            float nota1, nota2, nota3, nota4, nota5, media;
            string nome, classe, status;

            nota1 = Convert.ToInt32(txtNota1.Text);
            nota2 = Convert.ToInt32(txtNota2.Text);
            nota3 = Convert.ToInt32(txtNota3.Text);
            nota4 = Convert.ToInt32(txtNota4.Text);
            nota5 = Convert.ToInt32(txtNota5.Text);

            nome = (txtNome.Text);
            classe = (txtClasse.Text);
            status = "";
                    
            media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            

            if (media >= 7 && media <= 10)
            {
                status = ("está aprovado");
            }
            else if (media >=5 && media < 7)
            {
                status = ("está de recuperação");
            }
            
            else if (media < 5 && media >= 0)
            {
                status = ("está reprovado");
            }

            else
            {
                lblStatus.Text = ("Nota inválida");
            }

            lblMedia.Text = ("Aluno " + nome + " teve média de " + media.ToString("N1") + " e " + status);

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show(); 
        }
    }
}
