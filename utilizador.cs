using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha_12_ex1
{
    class utilizadores
    {
        public string username; //declaração de uma variavel do tipo string
        public string password; //declaração de uma variavel do tipo string
        public string email; //declaração de uma variavel do tipo string
        public int perfil; //declaração de uma variavel do tipo int

        public utilizadores() //criação de um contrutor vazio
        {

        }
        public utilizadores(string username, string password, string email, string tipoutilizador , int perfil)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.perfil = perfil;
        }


    }
}
