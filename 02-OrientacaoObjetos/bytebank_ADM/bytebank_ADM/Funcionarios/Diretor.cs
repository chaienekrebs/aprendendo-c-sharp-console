using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor: FuncionarioAutenticado
    {
        public Diretor(string cpf):base(cpf, 5000)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }



        public override double GetBonificacao()
        {
            // Chava o GetBonificacao da classe Funcionario através do base
            return Salario * 0.5;
        }

    }
}
