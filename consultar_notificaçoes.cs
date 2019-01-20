﻿using System;
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
            int line = dataGridView2.CurrentCell.RowIndex;
            File.CreateText(apoio);


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

        private void button3_Click(object sender, EventArgs e)
        {
            Resposta_por.Visible = true;
            Data_da_Resposta.Visible = true;
            Resposta.Visible = true;
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
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.CustomFormat = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
