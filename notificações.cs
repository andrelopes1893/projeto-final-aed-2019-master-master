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
    public partial class notificações : Form
    {
        string topicosdeassuntos = @"topicosdeassuntos.txt";

        public notificações()
        {
            InitializeComponent();
        }

        private void notificações_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            nome2.Visible = false;
            textBox1.Text = variaveis.nomeut;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripMenuItem3.Text = DateTime.Now.ToString("hh:mm:ss || dd/MM/yyyy");
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
                notificações form4 = new notificações();
                form4.Show();
                this.Hide();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //faz com que quando se carrega na "tool strip menu item 2", se volta para o form2
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina o programa
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CRIAR FICHEIRO QUE RECEBE AS NOTIFICAÇÕES DOS DOCENTES
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        //adicionar texto do ficheiro salas.txt à COMBOBOX1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string topicosdeassuntos = @"topicosdeassuntos.txt";
            string[] linha1 = File.ReadAllLines(topicosdeassuntos);
            
            if (File.Exists(topicosdeassuntos))
            {
                StreamReader sr = File.OpenText(topicosdeassuntos);
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    comboBox1.Items.Add(linha); //adiciona as linhas do ficheiro à combobox
                }
                sr.Close();
            }
            for (int i = 0; i < linha1.Length; i++)
            {
                
            }
        }
    }
}
