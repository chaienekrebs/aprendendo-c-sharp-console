using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usurioAutenticado = funcionario.Autenticar(senha);
            if (usurioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta!");
                return false;
            }
        }
    }
}
