using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteContas : FuncionarioAutenticado
    {
        public GerenteContas(string cpf) : base(cpf, 4000)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }

        public override double GetBonificacao()
        {
            // Chava o GetBonificacao da classe Funcionario através do base
            return Salario * 0.250;
        }

    }
}
