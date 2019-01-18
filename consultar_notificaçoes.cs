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
            string linha = ""; //Fazer uma variavel do tipo string para tomar os valores de uma linha do ficheiro

            if (radioButton1.Checked == true)
            {
                linha = "Pendente"; //notificaçao pendente
            }
            if (radioButton2.Checked == true)
            {
                linha = "Concluido"; //notificaçao concluida
            }

            if (valido(linha) == true)
            {
                dataGridView1.Rows.Clear(); //Elimina o conteudo existente na datagridview.
                string fila = "";
                int numli = 0; //variavel para mudar linha
                sr = File.OpenText(notificações); //Abre o ficheiro para fazer a leitura deste.

                while ((fila = sr.ReadLine()) != null)
                {
                    string[] fill = fila.Split(';'); // divide as partes da string por ";"

                    if (File.Exists(notificações))
                    {
                        if (fill[7] == linha)
                        {
                            if (linha == "Concluido")
                            {
                                dataGridView1.Rows.Add(1); //adiciona linha à datagridview

                                dataGridView1[0, numli].Value = fill[0];
                                dataGridView1[1, numli].Value = fill[1];
                                dataGridView1[2, numli].Value = fill[4];
                                dataGridView1[3, numli].Value = fill[5];
                                dataGridView1[4, numli].Value = fill[6];
                                dataGridView1[5, numli].Value = fill[7];
                            }
                            if (linha == "Pendente")
                            {
                                dataGridView1.Rows.Add(1); //adiciona linha à datagridview

                                dataGridView1[0, numli].Value = fill[0];
                                dataGridView1[1, numli].Value = fill[1];
                                dataGridView1[2, numli].Value = fill[4];
                                dataGridView1[3, numli].Value = fill[5];
                                dataGridView1[4, numli].Value = fill[6];
                                dataGridView1[5, numli].Value = fill[7];
                            }
                            numli++; //variavel contadora aumenta
                        }
                    }
                }
                sr.Close(); //fecha o streamreader
            }
        }
    }
}
