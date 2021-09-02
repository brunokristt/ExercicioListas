using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioListas
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double aumento)
        {
            Salario += Salario * aumento / 100;
        }
        public override string ToString()
        {
            return "ID: " + Id +
            " Nome: " + Nome +
            " Salário: " + Salario.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
