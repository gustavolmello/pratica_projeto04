using PraticaProjeto04.Entities;
using PraticaProjeto04.Repositories;
using System;

namespace PraticaProjeto04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n - CONTROLE DE PRODUTOS E FORNECEDORES - ");

            try
            {
                var connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDPraticaProjeto04;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                //iniciando o cadastro de um fornecedor..
                Console.WriteLine("\nCADASTRO DE FORNECEDOR\n");

                //criando um objeto para a classe fornecedor
                var fornecedor = new Fornecedor();
                fornecedor.IdFornecedor = Guid.NewGuid();

                Console.Write("Nome do fornecedor.....: ");
                fornecedor.Nome = Console.ReadLine();

                Console.Write("CNPJ do fornecedor.....: ");
                fornecedor.Cnpj = Console.ReadLine();

                //instanciando a classe FornecedorRepository
                var fornecedorRepository = new FornecedorRepository(connectionstring);
                fornecedorRepository.Inserir(fornecedor);

                Console.WriteLine("\nFORNECEDOR CADASTRADO COM SUCESSO!");


            }
            catch (Exception e)
            {
                Console.WriteLine("\n Erro: " + e.Message);
            }




            Console.ReadKey();
        }
    }
}
