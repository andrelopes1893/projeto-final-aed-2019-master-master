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
        string comentarios = @"comentarios.txt";
        string linha = ""; //Fazer uma variavel do tipo string para tomar os valores de uma linha do ficheiro
        string fila = "";
        string data = DateTime.Today.ToString("dd/MM/yyyy");
        string hora = DateTime.Now.ToString("hh:mm:ss");
        int i;


        public consultar_notificaçoes()
        {
            InitializeComponent();
        }

        private void consultar_notificaçoes_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label8.Text = variaveis.nomeut;

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
            if (File.Exists(notificações))
            {
                sr = File.OpenText(notificações);
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] fill = linha.Split(';'); //divide as partes da string por ";"
                    if (comboBox2.Items.Contains(fill[0]) == false)
                    {
                        comboBox2.Items.Add(fill[0]);
                    }
                }
                sr.Close();
            }

            if (variaveis.id == 0 || variaveis.id == 1)
            {
                comboBox2.Enabled = true;
                panel2.Visible = true;
                Estado.ReadOnly = false;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.Text = variaveis.nomeut;
                panel2.Visible = false;
                Estado.ReadOnly = true;
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

        //criação do Método que vai confirmar se o usurio escolheu alguma opção dos radiobuttons
        public bool valido(string linha)
        {
            if (linha != "Pendente" && linha != "Concluido")
            {
                return false;
            }
            else if (linha == "Pendente" || linha == "Concluido")
            {
                return true;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //BOTÃO DE ENVIAR RESPOSTA
        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText(notificações);
            string linha3 = "";
            while ((linha3 = sr.ReadLine()) != null)
            {
                string[] words = linha.Split(';');
                //para confirmar
                if ((dataGridView1[0, i].Value.ToString() == words[0]) && (dataGridView1[1, i].Value.ToString() == words[1]) &&
                    (dataGridView1[4, i].Value.ToString() == words[4]) && (dataGridView1[5, i].Value.ToString() == words[5]) &&
                    (dataGridView1[6, i].Value.ToString() == words[6]) && (words[7] == ""));
                {
                    //após se confirmar a condição anterior, o texto é todo apagado e reinscrito já com a resposta
                    dataGridView1[6, i].Value = "Concluido";
                    sr.Close();
                    File.WriteAllText(notificações, "");
                    StreamWriter sw = File.AppendText(notificações);
                    for (int y = 0; y < dataGridView1.Rows.Count - 1; y++)
                    {
                        int index = dataGridView1.CurrentCell.RowIndex;
                        if (y == index)
                        {
                            sw.WriteLine(dataGridView1[0, y].Value.ToString() + ";" + dataGridView1[1, y].Value.ToString() + ";" + dataGridView1[2, y].Value.ToString() + ";" +
                                         dataGridView1[3, y].Value.ToString() + ";" + dataGridView1[4, y].Value.ToString() + ";" + dataGridView1[5, y].Value.ToString() + ";" +
                                         dataGridView1[6, y].Value.ToString() + ";" + "Resposta de:" + label8.Text + ";" + "Resposta:" + textBox2.Text + ";" + data + ";" + hora);
                        }
                        else
                        {
                            sw.WriteLine(dataGridView1[0, y].Value.ToString() + ";" + dataGridView1[1, y].Value.ToString() + ";" + dataGridView1[2, y].Value.ToString() + ";" +
                                         dataGridView1[3, y].Value.ToString() + ";" + dataGridView1[4, y].Value.ToString() + ";" + dataGridView1[5, y].Value.ToString() + ";" +
                                         dataGridView1[6, y].Value.ToString() + ";" + "Resposta de:" + label8.Text + ";" + "Resposta:" + textBox2.Text + ";" + data + ";" + hora);
                        }
                    }
                    sw.Close();
                    MessageBox.Show("Resposta Enviada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //BOTÃO DAS CONSULTAS (FILTROS) 
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); //Elimina o conteudo existente na datagridview.
            int numli = 0; //variavel para mudar linha.
            string fila = "";
            sr = File.OpenText(notificações); //Abre o ficheiro para fazer a leitura deste.
            
            sr.Close();
        }
    }
}
