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
    public partial class gestao_de_salas : Form
    {
        string diretorio = @"diretorio/";
        string salas = @"salas.txt";

        public gestao_de_salas()
        {
            InitializeComponent();
            nome.Visible = false;
            StreamReader sr;
            if (Directory.Exists(diretorio))
            {
                sr = File.OpenText(diretorio + salas);
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    listBox2.Items.Add(linha);
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("O ficheiro não fez upload ou está vazio!", "Erro no Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina o programa
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {

        }

        private void gestao_de_salas_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true; //ativa o timer    
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            //faz com que quando se carrega na "tool strip menu item 3", se volta para o form2
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende fazer Logout?", "Aviso de Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //se carregar no botão "yes" volta para o form1
            {
                //faz com que quando se carrega na "tool strip menu item 2", se volta para o form1
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }



            //escrever no ficheiro salas.txt a sala que é adicionada à listbox2 atraves da textbox2
            var linha = textBox2.Text;

            if (listBox2.Items.Contains(diretorio + textBox2.Text) != true)
            {
                StreamWriter sw;
                if (File.Exists(diretorio + salas) == true)
                {                    
                    sw = File.AppendText(diretorio + salas);
                    sw.WriteLine(linha);
                    sw.Close();
                }
                listBox2.Items.Add(textBox2.Text); //adiciona à listbox2 o conteudo escrito na textbox1
                sw = File.CreateText(diretorio + textBox2.Text + ".txt");
                sw.Close();
            }
            else
            {
                MessageBox.Show("Sala já existente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            
            
            //remover linha do ficheiro salas.txt que tem o texto igual à sala selecionada da listBox2
            if (File.Exists(diretorio + salas))
            {
                File.Delete(diretorio + listBox2.SelectedItem + ".txt");
                
                //remove o conteudo da listbox2 que nesta foi selecionado
                listBox2.Items.Remove(listBox2.SelectedItem);

                File.Delete(diretorio + salas);

                StreamWriter sw1 = File.CreateText(diretorio + salas);
                sw1.Close();

                StreamWriter sw2 = File.AppendText(diretorio + salas);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    sw2.WriteLine(listBox2.Items[i].ToString());
                }
                sw2.Close();

                MessageBox.Show("Sala removida com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("A sala " + listBox2.SelectedItem + " não se encontra no ficheiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //mete o timer a funcionar na "tool strip menu item 4"
            toolStripMenuItem4.Text = DateTime.Now.ToString("hh:mm:ss || dd/MM/yyyy"); 
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
