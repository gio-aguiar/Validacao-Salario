using System;
using System.Collections.Generic;
using Aula03Colecoes.models;
using Aula03Colecoes.models.Enuns;

namespace Aula03Colecoes 
{
    class program
    {
        static List <Funcionario> lista = new List<Funcionario>();

        static void Main (string[] args)
        {
            CriarLista();
            ExemplosListasColecoes();
        }

        public static void CriarLista()
        {
            Funcionario f1 = new Funcionario();
            f1.Id=1;
            f1.Nome = "Pedro";
            f1.Cpf= "12345678909";
            f1.DataAdmissao = DateTime.Parse("01/01/2001");
            f1.Salario = 100.00M;
            f1.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f1);

            Funcionario f2 = new Funcionario();
            f2.Id=2;
            f2.Nome = "Juliana";
            f2.Cpf= "12345678969";
            f2.DataAdmissao = DateTime.Parse("01/01/2021");
            f2.Salario = 100.00M;
            f2.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f2);

            Funcionario f3 = new Funcionario();
            f3.Id=3;
            f3.Nome = "Larissa";
            f3.Cpf= "12345678929";
            f3.DataAdmissao = DateTime.Parse("01/01/2003");
            f3.Salario = 100.00M;
            f3.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f3);



        }

        public static void ExibirLista()
        {
            string dados = "";
            for (int i = 0; i < lista.Count; i++)
            {
                dados += "============================================\n";
                dados += string.Format("ID {0} \n", lista[i].Id);
                dados += string.Format("Nome {0} \n", lista[i].Nome);
                dados += string.Format("CPF {0} \n", lista[i].Cpf);
                dados += string.Format("Admissão: {0:dd/mm/yyyy \n} {0} \n", lista[i].DataAdmissao);
                dados += string.Format("Salario {0} \n", lista[i].Salario);
                dados += string.Format("Tipo: {0} \n", lista[i].TipoFuncionario);
                dados += "============================================\n";
            }
            Console.WriteLine(dados);
        }

        public static void ObterPorId()
        {
            lista = lista.FindAll(x => x.Id == 1);
            ExibirLista();
        }

        public static void ExemplosListasColecoes ()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("********** Exemplos - Aula 03 Listas e Coleções *****************");
            CriarLista();
            int opcaoEscolhida = 0;
            do
            {
                Console.WriteLine("==============================");
                Console.WriteLine("--Digite o número referente a opção desejada: \n ---- 1 para obter por ID ---- \n 2 para adicionar funcionário \n 3 Para obter por ID \n Ou tecle qualquer número para sair");

                opcaoEscolhida = int.Parse(Console.ReadLine());
                string mensagem = string.Empty;
                switch (opcaoEscolhida)
                {
                    case 1:
                        ObterPorId();
                        break;
                    case 2:
                        AdicionarFuncionario();
                        break;

                    case 3:
                        Console.WriteLine("Digite o ID do funcionário que você deseja buscar");
                        int id = int.Parse(Console.ReadLine());
                        ObterPorId(id);
                        break;

                    case 4:
                        Console.WriteLine("Digite o salário para obter todos acima do valor indicado:");
                        decimal Salario = decimal.Parse(Console.ReadLine());
                        ObterPorSalario(Salario);
                        break;
                    default:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                }
            } while (opcaoEscolhida >=1 && opcaoEscolhida <=10); 
                
                Console.WriteLine("Obrigado por utilizar o sistema e volte sempre");
            
        }

        public static void AdicionarFuncionario()
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Digite o nome");
            f.Nome = Console.ReadLine();

             Console.WriteLine("Digite o salario");
            f.Salario = decimal.Parse(Console.ReadLine());

             Console.WriteLine("Digite a data de admissão:");
            f.DataAdmissao = DateTime.Parse(Console.ReadLine());

            if (string.IsNullOrEmpty(f.Nome))
            {
                Console.WriteLine("O nome deve ser preenchido");
                return;
            }
            else if (f.Salario == 0)
            {
                Console.WriteLine("O valor do salário não pode ser 0");
                return;
            }
            else 
            {
                lista.Add(f);
                ExibirLista();
            }


        }

        public static void ObterPorId(int id)
        {
            Funcionario fBusca = lista.Find(x => x.Id == id);
            Console.WriteLine($"Personagem encontrado: {fBusca.Nome}");
        }

        public static void ObterPorSalario(decimal valor) 
        {
            lista = lista.FindAll(x => x.Salario >= valor);
            ExibirLista();
        }





    }
}