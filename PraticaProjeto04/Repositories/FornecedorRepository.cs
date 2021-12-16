using Dapper;
using PraticaProjeto04.Entities;
using PraticaProjeto04.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaProjeto04.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        //atributo privado (campo)
        private readonly string _connectionstring;

        //método construtor da classe utilizado para que possamos passar como parametro
        //o valor da connectionstring do banco de dados para classe FornecedorRepository
        public FornecedorRepository(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public void Inserir(Fornecedor obj)
        {
            //escrevendo o comando SQL que será executado no banco
            var query = @"
                            INSERT INTO FORNECEDOR(IDFORNECEDOR, NOME, CNPJ)
                            VALUES(@IdFornecedor, @Nome, @Cnpj)
                        ";

            //abrindo uma conexão com o banco de dados
            using (var connection = new SqlConnection(_connectionstring))
            {
                //executando a query no banco de dados
                //passando os dados do objeto 'Fornecedor'
                connection.Execute(query, obj);
            }

        }

        public void Alterar(Fornecedor obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Fornecedor obj)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> Consultar()
        {
            throw new NotImplementedException();
        }

        public Fornecedor ConsultarPorCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}
