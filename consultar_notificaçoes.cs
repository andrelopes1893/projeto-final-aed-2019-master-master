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

namespace projeto_final
{
    public partial class consultar_notificaçoes : Form
    {
        StreamReader sr;
        string notificações = @"notificaçoes.txt";
        string diretorio = @"diretorio/";
        string salas = @"salas.txt";
        string linha = ""; //Fazer uma variavel do tipo string para tomar os valores de uma linha do ficheiro

        public consultar_notificaçoes()
        {
            InitializeComponent();
        }

        private void consultar_notificaçoes_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            if (Directory.Exists(diretorio))
            {
                sr = File.OpenText(diretorio + salas);
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    comboBox1.Items.Add(linha);
                }
                sr.Close();
            }

            if (variaveis.id == 0 || variaveis.id == 1)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = variaveis.nomeut;
            }            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripMenuItem4.Text = DateTime.Now.ToString("hh:mm:ss || dd/MM/yyyy");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina o programa
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende fazer Logout?", "Aviso de Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //se carregar no botão "yes" volta para o form1
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else //caso contrario, se carregar no botão "no", fica no form atual
            {
                consultar_notificaçoes form10 = new consultar_notificaçoes();
                form10.Show();
                this.Hide();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //faz com que quando se carrega na "tool strip menu item 2", se volta para o form2
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        // criação do Método que vai confirmar se o usurio escolheu alguma opção dos radiobuttons
        public bool valido(string linha)
        {
            if (linha != "Pendente" && linha != "Concluido")
            {
                return false;
            }
            else if (linha == "Pendente" && linha == "Concluido")
            {
                return true;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
