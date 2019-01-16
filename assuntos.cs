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
    public partial class assuntos : Form
    {
        string topicosdeassuntos = @"topicosdeassuntos.txt";        
        
        public assuntos()
        {
            InitializeComponent();
        }

        private void assuntos_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina o programa
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //faz com que quando se carrega na "tool strip menu item 3", abra uma mensagem de aviso. Se se carregar no botao "Yes", é feito o log out e volta-se para form inicial
            if (MessageBox.Show("Tem a certeza que pretende fazer Logout?", "Aviso de Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            //caso contrario, se carregar no botão "No", fica no form atual
            else
            {
                assuntos form9 = new assuntos();
                form9.Show();
                this.Hide();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //faz com que quando se carrega na "tool strip menu item 3", se volta para o form2
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripMenuItem4.Text = DateTime.Now.ToString("hh:mm:ss || dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //escreve no ficheiro topicosdeassuntos.txt o assunto que é adicionado à listbox1 atraves da textbox1
            var linha = textBox1.Text;
            
            if (listBox1.Items.Contains(textBox1.Text) != true)
            {
                if (File.Exists(topicosdeassuntos) == true)
                {
                    string[] linha1 = File.ReadAllLines(topicosdeassuntos);
                    int maior = -999;
                    for (int i = 0; i < linha1.Length; i++)
                    {
                        if (Convert.ToInt16(linha1[i].Split(';')[0]) > maior)
                        {
                            maior = Convert.ToInt16(linha1[i].Split(';')[0]);
                        }
                    }
                    variaveis.contador = maior + 1;
                    StreamWriter sw;
                    sw = File.AppendText(topicosdeassuntos);
                    sw.WriteLine(variaveis.contador + "; " + linha + ";");
                    sw.Close();
                }
                listBox1.Items.Add(variaveis.contador + "; " + textBox1.Text + ";"); //adiciona à listbox1 o conteudo escrito na textbox1
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Item já existente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //remove o conteudo da listbox1 que nesta foi selecionado
            listBox1.Items.Remove(listBox1.SelectedItem);

            //remove linha do ficheiro topicosdeassuntos.txt que tem o texto igual à sala selecionada da listBox2
            if (File.Exists(topicosdeassuntos))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    //Confirmação se a sala se encontra no sistema
                        //Se estiver registada no sistema, apaga todo o texto do ficheiro topicosdeassuntos.txt e volta a escrever de acordo com a listbox1, sem a sala que se removeu.
                        string linha;
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        //Apaga todo o texto do ficheiro
                        File.WriteAllText(@"topicosdeassuntos.txt", "");
                        StreamWriter sw = File.AppendText(topicosdeassuntos);
                        //Escreve o novo texto
                        string num = listBox1.Items.Count.ToString();
                        int num1 = Convert.ToInt16(num);
                        for (int a = 0; a < num1; a++)
                        {
                            linha = listBox1.Items[a].ToString();
                            sw.WriteLine(linha);
                        }
                        sw.Close();
                        MessageBox.Show("Assunto removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        goto end;                    
                }
                MessageBox.Show("O Assunto selecionado não se encontra no ficheiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            end:;
            }
            else
            {
                MessageBox.Show("O Assunto selecionado não se encontra no ficheiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //botao que atualiza os dados atuais no ficheiro, na listbox
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            StreamReader sr;
            if (File.Exists(topicosdeassuntos))
            {
                sr = File.OpenText(topicosdeassuntos);
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
        }
    }
}
