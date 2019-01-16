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
    public partial class software : Form
    {
        StreamWriter sw;
        string diretorio = @"diretorio/";
        //string oSoftware = @"oSoftware.txt";
        string data = DateTime.Today.ToString("dd/MM/yyyy");
        string hora = DateTime.Now.ToString("hh:mm:ss");

        public software()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina o programa
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //faz com que quando se carrega na "tool strip menu item 2", se volta para o form2
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
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
                software form10 = new software();
                form10.Show();
                this.Hide();
            }
        }

        private void software_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            string licenças = @"licenças.txt";
            StreamReader sr;
            //confirma se existe o ficheiro salas
            if (File.Exists(licenças))
            {
                //existindo, abre-o para colocar que salas se encontram no sistema
                sr = File.OpenText(licenças);
                string linha;
                //adicionar texto do ficheiro salas.txt à COMBOBOX2
                while ((linha = sr.ReadLine()) != null)
                {
                    comboBox1.Items.Add(linha);
                }
                sr.Close();
            }

            string salas = @"salas.txt";
            StreamReader sr1;
            //confirma se existe o ficheiro salas
            if (File.Exists(diretorio + salas))
            {
                //existindo, abre-o para colocar que salas se encontram no sistema
                sr1 = File.OpenText(diretorio + salas);
                string linha;
                //adicionar texto do ficheiro salas.txt à COMBOBOX2
                while ((linha = sr1.ReadLine()) != null)
                {
                    comboBox2.Items.Add(linha);
                }
                sr1.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripMenuItem4.Text = DateTime.Now.ToString("hh:mm:ss || dd/MM/yyyy");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //CRIAR FICHEIRO QUE RECEBE O SOFTWARE
        private void button2_Click(object sender, EventArgs e)
        {
            //se o ficheiro pretendido existir
            if (File.Exists(diretorio + comboBox2.Text + ".txt"))
            {
                //estrutura da linha a adicionar no ficheiro selecionado 
                string linha = (textBox1.Text + ";" + data + ";" + hora + ";" + comboBox1.Text);
                //se uma das condiçoes se verificar, aparece a message box
                if (textBox1.Text == "" || comboBox2.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Os requisitos válidos para adicionar software não se encontram preenchidos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //caso contraio, o codigo é executado
                else
                {
                    //Adiciona no ficheiro 
                    sw = File.AppendText(diretorio + comboBox2.Text + ".txt");
                    sw.WriteLine(linha);
                    sw.Close();
                    button2.Enabled = false;
                }
            }
            //se o ficheiro(nome da sala) pretendido não existir
            else
            {
                MessageBox.Show("A Sala não existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            if (Directory.Exists(diretorio))
            {
                sr = File.OpenText(diretorio + comboBox2.Text + ".txt");
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(linha);
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("O ficheiro não fez upload ou está vazio!", "Erro no Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            button1.Enabled = false;
        }
    }
}
