using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.Models
{
    public class Cliente : Usuario
    {
        public Cliente(string nome, string nomeUsr, string email)
        {
            Console.WriteLine("Criando CLIENTE.");
            Random rd = new Random();
            Id = rd.Next();
            Nome = nome;
            NomeUsr = nomeUsr;
            Email = email;
            EhAtivo = true;
            NivelAcc = false;
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
