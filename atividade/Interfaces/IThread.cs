using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.Interfaces
{
    public interface IThread
    {
        public void CriarThread();
        public void EditarThread(string nomeUsr);
        public void ResponderThread();
        public void ExcluirThread(string nomeUsr);
    }
}
