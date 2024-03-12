using System;
using System.Collections.Generic;
using Aula03Colecoes.models;
using Aula03Colecoes.models.Enuns;

namespace Aula03Colecoes 
{
    class program
    {
        static List <Funcionario> lista = new list<Funcionario>();

        static void Main (string[] args)
        {
            CriarLista();
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
                dados += string.Format("ID {0} \n", lista[i].id);
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
                Console.WriteLine("--Digite o número referente a opção desejada: \n ---- 1 para obter por ID ---- \n Ou tecle qualquer número para sair");

                opcaoEscolhida = int.Parse(Console.ReadLine());
                string mensagem = string.Empty;
                switch (opcaoEscolhida)
                {
                    case 1:
                        ObterPorId();
                        break;
                    default:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                }
            } while (opcaoEscolhida >=1 && opcaoEscolhida <=10); 
                
                Console.WriteLine("Obrigado por utilizar o sistema e volte sempre");
            
        }


    }
}