using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf):base(cpf, 2000)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }

        public override double GetBonificacao()
        {
            // Chava o GetBonificacao da classe Funcionario através do base
            return Salario * 0.20;
        }
    }
}
