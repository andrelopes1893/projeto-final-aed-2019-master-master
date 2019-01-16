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
    public partial class consultas : Form
    {
        string diretorio = @"diretorio/";
        string salas = @"salas.txt";
        StreamReader sr;

        public consultas()
        {
            InitializeComponent();
        }

        private void consultas_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            nome.Visible = false;

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
                consultas form5 = new consultas();
                form5.Show();
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina o programa
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fila = "";
            int numli = 0; //variavel para mudar linha

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecione uma sala para verificar software!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sr = File.OpenText(diretorio + comboBox1.Text + ".txt"); //Abre o ficheiro para fazer a leitura deste.

                while ((fila = sr.ReadLine()) != null)
                {
                    string[] fill = fila.Split(';'); // divide as partes da string por ";"

                    if (File.Exists(diretorio + comboBox1.Text + ".txt"))
                    {
                        dataGridView1.Rows.Add(1); //adiciona linha à datagridview

                        dataGridView1[0, numli].Value = fill[0];
                        dataGridView1[1, numli].Value = fill[1];
                        dataGridView1[2, numli].Value = fill[2];
                        dataGridView1[3, numli].Value = fill[3];

                        numli++; //variavel contadora aumenta
                    }                    
                }
                sr.Close(); //fecha o streamreader
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            //sempre que se seleciona uma sala na comboBox1, faz-se refresh na datagridview ficando esta vazia
            dataGridView1.Rows.Clear();
        }
    }
}
