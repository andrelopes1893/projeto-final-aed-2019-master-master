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
    public partial class Administrador : Form
    {
        string contas = @"contas.txt";
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            nome2.Visible = false;
            timer1.Enabled = true;
            if (variaveis.id ==1)
            {
                button2.Visible = false;
            }
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
                Administrador form7 = new Administrador();
                form7.Show();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripMenuItem4.Text = DateTime.Now.ToString("hh:mm:ss || dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestao_de_salas form6 = new gestao_de_salas();
            form6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          if(panel1.Visible == true)
          {
                panel1.Visible = false;
          }
            else
            {
                panel1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            assuntos form9 = new assuntos();
            form9.Show();
            this.Hide();
        }

        private void nome1_Click(object sender, EventArgs e)
        {
            nome1.Clear();
        }

        private void email1_Click(object sender, EventArgs e)
        {
            email1.Clear();
        }

        private void passe1_Click(object sender, EventArgs e)
        {
            passe1.Clear();
        }

        private void passe1_TextChanged(object sender, EventArgs e)
        {
            passe1.PasswordChar = '*';
        }

        private void confirmar1_TextChanged(object sender, EventArgs e)
        {
            confirmar1.PasswordChar = '*';
        }

        private void confirmar1_Click(object sender, EventArgs e)
        {
            confirmar1.Clear();
        }

        //Confirma se o nome de utilizador ja existe 
        public bool valido(string util)
        {
            StreamReader sr;
            sr = File.OpenText(contas);
            string linha;

            while ((linha = sr.ReadLine()) != null)//percore o ficheiro 
            {
                string[] fill = linha.Split(';'); // faz a separação para poder obter o que e realmente necessario para validar esta função 
                if (fill.Count() < 3)
                {
                    sr.Close();
                    return true;
                }
                else
                {
                    if (fill[1] == util) //compara o utilizador com os elementos (utilizadores) presentes num array 
                    {
                        sr.Close();
                        return false;
                    }
                }
            }
            sr.Close();
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            int cont = 0;

            string li;
            StreamReader sr = File.OpenText(contas);

            while ((li = sr.ReadLine()) != null)
            {
                cont++;
            }

            sr.Close();


            //Chama instância vazia e atribui valores a classe utilizador
            utilizadores user = new utilizadores();
            user.perfil = cont;
            user.username = nome1.Text;
            user.password = passe1.Text;
            user.email = email1.Text;
            string util = user.username;


            if (nome1.Text == "" || nome1.Text == "Nome de utilizador..." || passe1.Text == "" || passe1.Text == "Palavra-passe..." || email1.Text == "" || email1.Text == "Email..." || confirmar1.Text == "" || confirmar1.Text == " Confirmar Palavra-passe...") //opções que fazem com que o botão para registar não funcione
            {
                MessageBox.Show("Os requesitos para criar uma conta não se encontram todos corretos!", "Erro na criação de conta", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensagem de erro
            }
            else if (passe1.Text != confirmar1.Text) //se o texto da textbox passe for diferente do texto da textbox confirmar, dá mensagem de erro!
            {
                MessageBox.Show("As Palavras passe não coincidem!", "Erro ao Criar Conta", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensagem de erro!
            }

            else //caso os campos estejam completados 
            {
                if (valido(util) == true)//Caso de o user ser inexistente 
                {
                    if (passe1.Text == confirmar1.Text)//Caso houver confirmação do password
                    {
                        //Faz a extruturação para adicionar no ficheiro 
                        string linha = ((user.perfil.ToString()) + ";" + user.username + ";" + user.email + ";" + user.password + ";" + 1);

                        //Adiciona no ficheiro 
                        StreamWriter sw;
                        sw = File.AppendText(contas);
                        sw.WriteLine(linha);
                        sw.Close();
                        int i = 0;
                        string[] linha1 = File.ReadAllLines(contas);
                        int c = 0;
                        for (i = 0; i < linha1.Length; i++)
                        {
                            if (linha1[i].Split(';')[1] == nome1.Text && linha1[i].Split(';')[3] == passe1.Text)
                            {
                                //variaveis.id = Convert.ToInt16(linha1[i].Split(';')[4]);
                                //variaveis.nomeut = nome1.Text;
                                c++;
                            }
                        }
                        MessageBox.Show("Conta criada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else //Caso não haja confirmacao do password 
                    {
                        MessageBox.Show("Os passwords são diferentes", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username já existe!", "Username existente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            nome1.Clear();
            email1.Clear();
            passe1.Clear();
            confirmar1.Clear();
            panel1.Visible = false;
            

        }  

        private void nome1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

