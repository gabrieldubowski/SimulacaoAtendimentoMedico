using System;
using System.Collections.Generic;

namespace SimulacaoAtendimentoMedico
{
    public class Pacientes
    {
        private List<string> pacientes = new List<string>();

        public void Menu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu - Gerenciar Pacientes ===");
                Console.WriteLine("1. Cadastrar Paciente");
                Console.WriteLine("2. Remover Paciente");
                Console.WriteLine("3. Exibir Pacientes");
                Console.WriteLine("4. Buscar Paciente");
                Console.WriteLine("5. Voltar");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarPaciente();
                        break;
                    case 2:
                        RemoverPaciente();
                        break;
                    case 3:
                        ExibirPacientes();
                        break;
                    case 4:
                        BuscarPaciente();
                        break;
                    case 5:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 5);
        }

        private void CadastrarPaciente()
        {
            try
            {
                Console.Write("Digite o nome do paciente: ");
                string nome = Console.ReadLine();
                pacientes.Add(nome);
                Console.WriteLine("Paciente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar paciente: {ex.Message}");
            }
            Console.ReadKey();
        }

        private void RemoverPaciente()
        {
            try
            {
                Console.Write("Digite o nome do paciente a ser removido: ");
                string nome = Console.ReadLine();
                if (pacientes.Contains(nome))
                {
                    pacientes.Remove(nome);
                    Console.WriteLine("Paciente removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Paciente não encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover paciente: {ex.Message}");
            }
            Console.ReadKey();
        }

        private void ExibirPacientes()
        {
            Console.WriteLine("Lista de Pacientes:");
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente);
            }
            Console.ReadKey();
        }

        private void BuscarPaciente()
        {
            Console.Write("Digite o nome do paciente a ser buscado: ");
            string nome = Console.ReadLine();
            if (pacientes.Contains(nome))
            {
                Console.WriteLine($"Paciente {nome} encontrado!");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado.");
            }
            Console.ReadKey();
        }
    }
}
