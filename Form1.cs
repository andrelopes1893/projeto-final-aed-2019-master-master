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
    public partial class Form1 : Form
    {
        string notificações = @"notificaçoes.txt";
        StreamReader sr;
        string contas = @"contas.txt";
        public Form1()
        {
            InitializeComponent();
        }      

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripMenuItem2.Text = DateTime.Now.ToString("hh:mm:ss || dd/MM/yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            email.Visible = false;
            confirmar.Visible = false;
            registar.Visible = false;    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            nome.Clear();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            nome.Clear();
        }

        private void conta_Click(object sender, EventArgs e)
        {
            if (email.Visible == true)
            {
                email.Visible = false;
                confirmar.Visible = false;
                label2.Text = "Inicializar Sessão";
                conta.Text = "Criar Conta";
                registar.Visible = false;
                entrar.Visible = true;
            }
            else
            {
                email.Visible = true;
                confirmar.Visible = true;
                label2.Text = "Criar Conta";
                conta.Text = "Já tenho conta";
                registar.Visible = true;
                entrar.Visible = false;
            }   
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (email.Visible == true)
            {
                label2.Text = "Crie a sua Conta";
            }
        }

        private void email_Click(object sender, EventArgs e)
        {
            email.Clear();
        }

        private void passe_Click(object sender, EventArgs e)
        {
            passe.Clear();  
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            confirmar.Clear();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina o programa
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] linha1 = File.ReadAllLines(contas);
            int c = 0;
            for ( i = 0; i < linha1.Length; i++)
            {
                //MessageBox.Show(username + password);
                if (linha1[i].Split(';')[1] == nome.Text && linha1[i].Split(';')[3] == passe.Text)
                {
                    variaveis.id = Convert.ToInt16(linha1[i].Split(';')[4]);
                    variaveis.nomeut = nome.Text;
                    Form2 form2 = new Form2();
                    form2.Show(); //abre o form "sessao iniciada" quando se carrega no botom "log in"
                    this.Hide(); //esconde os outros forms
                    c++;

                    if (variaveis.id == 0 || variaveis.id == 1)  // se a conta que der login for de administrador(0) ou for conta de segurança(1)
                    {
                        if (File.Exists(notificações)) //se o ficheiro notificaçoes.txt existir
                        {
                            sr = File.OpenText(notificações); //abre o ficheiro
                            string linha;
                            while ((linha = sr.ReadLine()) != null) //enquanto a linha do ficheiro for diferente de nulo
                            {
                                string[] fill = linha.Split(';'); //divide as partes da string por ";"
                                if (fill[7] == "Pendente") //se encontrar no indice 7 do array fill um estado "pendente", executa a messagebox
                                {
                                    //message box que diz que existem notificaçoes pendentes
                                    MessageBox.Show("Aviso: Existem notificações pendentes, para resolver! Tente resolver os pedidos dos docentes o mais brevemente possível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    //quebra o ciclo caso a condiçao seja verdadeira
                                    break;
                                }
                            }
                            sr.Close();
                        }
                    }
                }                
            }
            //se a textbox1 ou a textbox2 estiverem vazias, da mensagem de erro
            if (nome.Text == "" || nome.Text == "Nome de utilizador..." || passe.Text == "" || passe.Text == "Palavra-passe...") 
            {
                MessageBox.Show("O Username ou a Password estão em falta!", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensagem de erro
            }
            else if (c==0)
            {
                MessageBox.Show("A password não corresponde ao username usado!", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensagem de erro
            }
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

        private void registar_Click(object sender, EventArgs e)
        {
            //Conta os elementos do ficheiro para poder atribuir um ID sendo que esse tem de ser diferente dos existentes 
            int cont = 0;

            string li;
            StreamReader sr = File.OpenText(contas); //abre o ficheiro contas
           
            while ((li = sr.ReadLine()) != null)
            {
                cont++; //adiciona 1 ao Id, em relacao ao ID anterior, do nova linha
            }

            sr.Close();

            if (File.ReadAllText(contas) != "")
            {
                //Chama instância vazia e atribui valores a classe utilizador
                utilizadores user = new utilizadores();
                user.perfil = cont;
                user.username = nome.Text;
                user.password = passe.Text;
                user.email = email.Text;
                string util = user.username;

                //opções que fazem com que o botão para registar não funcione
                if (nome.Text == "" || nome.Text == "Nome de utilizador..." || passe.Text == "" || passe.Text == "Palavra-passe..." || email.Text == "" || email.Text == "Email..." || confirmar.Text == "" || confirmar.Text == " Confirmar Palavra-passe...") 
                {
                    MessageBox.Show("Os requesitos para criar uma conta não se encontram todos corretos!", "Erro na criação de conta", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensagem de erro
                }
                //se o texto da textbox passe for diferente do texto da textbox confirmar, dá mensagem de erro!
                else if (passe.Text != confirmar.Text) 
                {
                    MessageBox.Show("As Palavras passe não coincidem!", "Erro ao Criar Conta", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensagem de erro!
                }

                else //caso os campos estejam completados 
                {
                    if (valido(util) == true)//Caso de o user ser inexistente 
                    {
                        if (passe.Text == confirmar.Text)//Caso houver confirmação do password
                        {
                            //Faz a extruturação para adicionar no ficheiro 
                            string linha = ((user.perfil.ToString()) + ";" + user.username + ";" + user.email + ";" + user.password + ";" + 2);

                            //Adiciona no ficheiro contas.txt
                            StreamWriter sw;
                            sw = File.AppendText(contas);
                            sw.WriteLine(linha);
                            sw.Close();
                            int i = 0;
                            string[] linha1 = File.ReadAllLines(contas);
                            int c = 0;
                            for (i = 0; i < linha1.Length; i++)
                            {
                                if (linha1[i].Split(';')[1] == nome.Text && linha1[i].Split(';')[3] == passe.Text)
                                {
                                    variaveis.id = Convert.ToInt16(linha1[i].Split(';')[4]);
                                    variaveis.nomeut = nome.Text;
                                    Form2 form2 = new Form2();
                                    form2.Show(); //abre o form "sessao iniciada" quando se carrega no botom "log in"
                                    this.Hide(); //esconde os outros forms
                                    c++;
                                }
                            }
                        }
                        else //Caso não haja confirmacao do password 
                        {
                            MessageBox.Show("Os passwords são diferentes", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensagem de erro
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username já existe!", "Username existente!", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensagem de erro
                    }
                }
            }
            else
            {
                //Chama instância vazia e atribui valores a classe utilizador
                utilizadores user = new utilizadores();
                user.perfil = cont;
                user.username = nome.Text;
                user.password = passe.Text;
                user.email = email.Text;
                string util = user.username;

                //var contem = "@esmad.ipp.pt";
                //bool existe = email.Text.Contains(contem);

                if (nome.Text == "" || nome.Text == "Nome de utilizador..." || passe.Text == "" || passe.Text == "Palavra-passe..." || email.Text == "" || email.Text == "Email..." || confirmar.Text == "" || confirmar.Text == " Confirmar Palavra-passe...") //opções que fazem com que o botão para registar não funcione
                {
                    MessageBox.Show("Os requesitos para criar uma conta não se encontram todos corretos!", "Erro na criação de conta", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensagem de erro
                }
                else if (passe.Text != confirmar.Text) //se o texto da textbox passe for diferente do texto da textbox confirmar, dá mensagem de erro!
                {
                    MessageBox.Show("As Palavras passe não coincidem!", "Erro ao Criar Conta", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensagem de erro!
                }                

                else //caso os campos estejam completados 
                {
                    if (valido(util) == true)//Caso de o user ser inexistente 
                    {
                        if (passe.Text == confirmar.Text)//Caso houver confirmação do password
                        {
                            //Faz a extruturação para adicionar no ficheiro 
                            string linha = ((user.perfil.ToString()) + ";" + user.username + ";" + user.email + ";" + user.password + ";" + 0);

                            //Adiciona no ficheiro contas
                            StreamWriter sw;
                            sw = File.AppendText(contas);
                            sw.WriteLine(linha);
                            sw.Close();
                            int i = 0;
                            string[] linha1 = File.ReadAllLines(contas);
                            int c = 0;
                            for (i = 0; i < linha1.Length; i++)
                            {
                                //MessageBox.Show(username + password);
                                if (linha1[i].Split(';')[1] == nome.Text && linha1[i].Split(';')[3] == passe.Text)
                                {
                                    variaveis.id = Convert.ToInt16(linha1[i].Split(';')[4]);
                                    variaveis.nomeut = nome.Text;
                                    Form2 form2 = new Form2();
                                    form2.Show(); //abre o form "sessao iniciada" quando se carrega no botom "log in"
                                    this.Hide(); //esconde os outros forms
                                    c++;
                                }
                            }
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
            }
        }

        private void passe_TextChanged(object sender, EventArgs e)
        {
            passe.PasswordChar = '*';
        }

        private void confirmar_TextChanged(object sender, EventArgs e)
        {
            confirmar.PasswordChar = '*';
        }
    }

    internal class utilizadores
    {
        internal int perfil;
        internal string username;
        internal string password;
        internal string email;

        public utilizadores()
        {
        }
    }
}
