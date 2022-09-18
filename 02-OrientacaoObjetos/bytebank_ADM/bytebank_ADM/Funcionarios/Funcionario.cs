﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public static int totalFuncionarios { get; private set; }
        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario= salario;
            totalFuncionarios++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
