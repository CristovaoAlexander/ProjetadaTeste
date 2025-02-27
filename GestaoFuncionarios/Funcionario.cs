using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFuncionarios
{
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        public string Funcao { get; set; }

        public Funcionario(string nome, DateTime dataNascimento, decimal salario, string funcao)
            : base(nome, dataNascimento)
        {
            Salario = salario;
            Funcao = funcao;
        }

        public override string ToString()
        {
            return base.ToString() + $", Salário: {Salario:C}, Função: {Funcao}";
        }
    }
}
