using atividade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.Models
{
    public abstract class Usuario : IThread
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeUsr { get; set; }
        public string Email { get; set; }
        public bool EhAtivo { get; set; }
        public bool NivelAcc { get; set; }

        public abstract void CriarThread();

        public abstract void EditarThread(string nomeUsr);

        public abstract void ExcluirThread(string nomeUsr);

        public abstract void ResponderThread();
       
    }
}
