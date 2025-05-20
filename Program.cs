using System;

namespace SimulacaoAtendimentoMedico
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1. Gerenciar Pacientes");
                Console.WriteLine("2. Gerenciar Consultas");
                Console.WriteLine("3. Gerenciar Agenda");
                Console.WriteLine("4. Gerenciar Tratamentos");
                Console.WriteLine("5. Buscar Paciente/Consulta");
                Console.WriteLine("6. Encerrar");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        new Pacientes().Menu();
                        break;
                    case 2:
                        new Consultas().Menu();
                        break;
                    case 3:
                        new Agenda().Menu();
                        break;
                    case 4:
                        new Tratamentos().Menu();
                        break;
                    case 5:
                        new Pesquisa().Menu();
                        break;
                    case 6:
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 6);
        }
    }
}
