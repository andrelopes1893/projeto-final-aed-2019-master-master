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
        string apoio = @"apoio.txt";
        string linha = ""; //Fazer uma variavel do tipo string para tomar os valores de uma linha do ficheiro
        string fila = "";
        int i;
        

        public consultar_notificaçoes()
        {
            InitializeComponent();
        }

        private void consultar_notificaçoes_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label8.Text = variaveis.nomeut;

            //faz com que aundo se dá o load, a datetimepicker1 venha vazia
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " "; 

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
            int line = dataGridView2.CurrentCell.RowIndex; //linha da datagridview que se encontra selecionada
            StreamWriter sw = File.CreateText(apoio); //cria o ficheiro apoio.txtx
            sw.Close();

            string textoresporta = textBox2.Text; 
            string autorresposta = label8.Text;
            string dataresposta = DateTime.Today.ToString("dd/MM/yyyy");

            string resposta = (textoresporta + ";" + dataresposta + ";" + autorresposta + ";"); //conteudo da resposta a adicionar no ficheiro notificaçoes

            StreamReader sr1 = File.OpenText(notificações); //abre o ficheiro notificaçoes.txt
            string outralinha;

            while((outralinha = sr1.ReadLine()) != null)
            {
                string[] fill = outralinha.Split(';'); // divide as partes da string por ";"
                StreamWriter sw1 = File.AppendText(apoio); //adiciona texto no ficheiro apoio.txt 

                //se o indice 0 e 4 do array fill foram iguais ao conteudo das colunas 0 e 2, respetivamente, da datagridview
                if (dataGridView2[0, line].Value.ToString() == fill[0] && dataGridView2[2, line].Value.ToString() == fill[4])
                {
                   //adiciona/escreve o tipo de linha em baixo criado, no ficheiro apoio.txt
                    sw1.WriteLine(fill[0] + ";" + fill[1] + ";" + fill[2] + ";" + fill[3] + ";" + fill[4] + ";" + fill[5] + ";" + fill[6] + ";" + "Concluído" + ";" + resposta); 
                    sw1.Close();
                }
                //caso contrario
                else
                {
                    //adiciona/escreve a "outralinha" no ficheiro apoio.txt
                    sw1.WriteLine(outralinha);
                    sw1.Close();
                }                
            }
            sr1.Close();

            File.Delete(notificações); //apaga o ficheiro notificaçoes
            StreamWriter sw2 = File.CreateText(notificações); //cria de novo o ficheiro notificaçoes
            sw2.Close(); 

            StreamReader sr2 = File.OpenText(apoio); //abre o ficheiro apoio.txt

            while ((outralinha = sr2.ReadLine()) != null)
            {
                //adiciona o texto no ficheiro notificaçoes.txt
                sw2 = File.AppendText(notificações); 
                sw2.WriteLine(outralinha); 
                sw2.Close();
            }
            sr2.Close();

            File.Delete(apoio); //apaga o ficheiro apoio.txt

            //envia uma mensagem de sucesso na resposta as notificaçoes
            MessageBox.Show("A resposta à notificação foi enviada com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //BOTÃO DAS CONSULTAS (FILTROS) 
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear(); //Elimina o conteudo existente na datagridview.
            int numli = 0; //variavel para mudar linha.
            string fila = "";


            string data1;
            string hoje = DateTime.Now.ToString("dd/MM/yyyy");
            data1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            sr = File.OpenText(notificações); //Abre o ficheiro para fazer a leitura deste.

            string state = "";
            if (radioButton1.Checked)
            {
                state = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                state = radioButton2.Text;
            }

            while ((fila = sr.ReadLine()) != null)
            {
                string[] fill = fila.Split(';'); // divide as partes da string por ";"

                if (comboBox2.Text == fill[0] || comboBox2.Text == "")
                {
                    if (comboBox1.Text == fill[1] || comboBox1.Text == "")
                    {
                        if (state == fill[7] || state == "")
                        {
                            if (data1 == fill[5] || data1 == hoje)
                            {
                                dataGridView2.Rows.Add(1); //adiciona linha à datagridview
                                dataGridView2[0, numli].Value = fill[0]; //adiciona na coluna 0 da datagrid o indice 0 do ficheiro notificaçoes
                                dataGridView2[1, numli].Value = fill[1];
                                dataGridView2[2, numli].Value = fill[4];
                                dataGridView2[3, numli].Value = fill[5];
                                dataGridView2[4, numli].Value = fill[7];
                                //dataGridView2[5, numli].Value = fill[8];
                                //dataGridView2[6, numli].Value = fill[9];
                                //dataGridView2[7, numli].Value = fill[10];
                                numli++; //variavel contadora aumenta                      
                            }
                        }
                    }
                }
            }
            sr.Close();
        }

        //BOTÃO DE VER RESPOSTAS
        private void button3_Click(object sender, EventArgs e)
        {
            Resposta_por.Visible = true; //torna a coluna resporta por, da datagridview visivel
            Data_da_Resposta.Visible = true; //torna a coluna data da resposta, da datagridview visivel
            Resposta.Visible = true; //torna a coluna resposta, da datagridview visivel

            dataGridView2.Rows.Clear(); //Elimina o conteudo existente na datagridview.
            int numli = 0; //variavel para mudar linha.
            string fila = "";


            string data1;
            string hoje = DateTime.Now.ToString("dd/MM/yyyy");
            data1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            sr = File.OpenText(notificações); //Abre o ficheiro para fazer a leitura deste.

            string state = "";
            if (radioButton1.Checked)
            {
                state = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                state = radioButton2.Text;
            }

            while ((fila = sr.ReadLine()) != null)
            {
                string[] fill = fila.Split(';'); // divide as partes da string por ";"

                if (comboBox2.Text == fill[0] || comboBox2.Text == "")
                {
                    if (comboBox1.Text == fill[1] || comboBox1.Text == "")
                    {
                        if (state == fill[7] || state == "")
                        {
                            if (data1 == fill[5] || data1 == hoje)
                            {
                                if (fill.Length>=12) // se o comprimento do array fill for maior ou igual que 12
                                {                              
                                    dataGridView2.Rows.Add(1); //adiciona linha à datagridview
                                    dataGridView2[0, numli].Value = fill[0]; //adiciona na coluna 0 da datagrid o indice 0 do ficheiro notificaçoes
                                    dataGridView2[1, numli].Value = fill[1];
                                    dataGridView2[2, numli].Value = fill[4];
                                    dataGridView2[3, numli].Value = fill[5];
                                    dataGridView2[4, numli].Value = fill[7];
                                    dataGridView2[5, numli].Value = fill[8];
                                    dataGridView2[6, numli].Value = fill[9];
                                    dataGridView2[7, numli].Value = fill[10];
                                    numli++; //variavel contadora aumenta   
                                }

                                else if (fill.Length < 12) // se o comprimento do array fill for menos que 12
                                {
                                    dataGridView2.Rows.Add(1); //adiciona linha à datagridview
                                    dataGridView2[0, numli].Value = fill[0]; //adiciona na coluna 0 da datagrid o indice 0 do ficheiro notificaçoes
                                    dataGridView2[1, numli].Value = fill[1];
                                    dataGridView2[2, numli].Value = fill[4];
                                    dataGridView2[3, numli].Value = fill[5];
                                    dataGridView2[4, numli].Value = fill[7];
                                    dataGridView2[5, numli].Value = "-";
                                    dataGridView2[6, numli].Value = "-";
                                    dataGridView2[7, numli].Value = "-";
                                    numli++; //variavel contadora aumenta   
                                }
                            }
                        }
                    }
                }
            }
            sr.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        //botao que apaga os filtros e limpa o conteudo da datagridview
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear(); //Elimina o conteudo existente na datagridview.
            comboBox1.Text = ""; //Elimina o conteudo existente na combobox1
            comboBox2.Text = ""; //Elimina o conteudo existente na combobox2
            textBox2.Text = ""; //Elimina o conteudo existente na textbox2
            dateTimePicker1.CustomFormat = " ";
            radioButton1.Checked = false; //desceleciona o radio button1
            radioButton2.Checked = false; //desceleciona o radio button2
        }
    }
}
