using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aumento de salários");
            Console.Write("Quantos funcionários deseja cadastrar: ");
            int quantidade = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Funcionário #" + i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();

            }

            Console.Write("Digite o ID do funcionário que terá seu salário aumentado: ");
            int busca = int.Parse(Console.ReadLine());

            Funcionario selecionado = lista.Find(x => x.Id == busca);
            if (selecionado != null)
            {
                Console.Write("Digite a porcentagem do aumento: ");
                double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                selecionado.AumentarSalario(aumento);


            }
            else
            {
                Console.WriteLine("Este ID não existe");

            }
            Console.WriteLine();
            Console.WriteLine("Atualização de funcionários");
            foreach(Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }





        }
    }
}
