using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de Empregados
            List<Empregado> list = new List<Empregado>();
            //Usuário vai entra com o números de Funcionários
            Console.Write("Entre com número de funcionários: ");
            //N será o número que o usuário vai colocar
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                //vai mostra a ordem dela Ex-funcionário #1
                Console.WriteLine($"Funcionário #{i} data:");
                //Usuário vai te que escolher entre sim ou não para o programa saber se é Terceirizado
                Console.Write("Tercerizado (s/n)? ");
                // o char está sendo usado para verificar o que o usuário coloco
                char ch = char.Parse(Console.ReadLine());
                //Usuário vai entra com o nome Do Funcionário
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                //Usuário vai entra com as Horas
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                //Usuário vai entra com o Valor Por Horas
                Console.Write("Valor Por Horas: ");
                double ValorPorHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //ele vai identifica se o usuário colocou s para saber que é terceirizado para mostrar o adicional Despesas
                if (ch == 's')
                {
                    //Usuário vai entra com o valor do Adicional Despesas
                    Console.Write("Adicional Despesas: ");
                    double cobrancaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Vai adicionar o FuncionárioTerceirizado na lista 
                    list.Add(new FuncionarioTerceirizado(nome, horas, ValorPorHoras, cobrancaAdicional));
                }
                else
                {
                    // Vai adicionar o Empregado na lista 
                    list.Add(new Empregado(nome, horas, ValorPorHoras));
                }
            }

            Console.WriteLine();
            //Pagamentos 
            Console.WriteLine("Pagamentos:");
            //Vai Imprimir os valores da lista pro usuário
            foreach (Empregado funcionario in list)
            {
                Console.WriteLine(funcionario.Nome + " - $ " + funcionario.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}