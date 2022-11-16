using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.Models
{
    public class Admin : Usuario
    {
        public Admin(string nome, string nomeUsr, string email)
        {
            Console.WriteLine("Criando ADMIN.");
            Random rd = new Random();
            Id = rd.Next();
            Nome = nome;
            NomeUsr = nomeUsr;
            Email = email;
            EhAtivo = true;
            NivelAcc = true;
        }
        public void FornecerAcesso(Usuario cliente)
        {
            if (NivelAcc)
            {
                cliente.NivelAcc = true;
                Console.WriteLine("Acesso fornecido ao usuário " + cliente.Nome);
            }
            else
            {
                Console.WriteLine("401: Perminssão negada");
            }
        }
        public override void CriarThread()
        {
            Console.WriteLine("Criando uma thread");

        }

        public override void EditarThread(string nomeUsr)
        {
            if (NivelAcc || nomeUsr == NomeUsr)
            {
                Console.WriteLine("Editando uma thread");
            }
            else
            {
                Console.WriteLine("401: Perminssão negada");
            }
        }

        public override void ExcluirThread(string nomeUsr)
        {
            if (NivelAcc || nomeUsr == NomeUsr)
            {
                Console.WriteLine("Excluindo uma thread");
            }
            else
            {
                Console.WriteLine("401: Perminssão negada");
            }
        }

        public override void ResponderThread()
        {
            Console.WriteLine("Respondendo uma thread");
        }
    }
}
