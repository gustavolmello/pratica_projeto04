using PraticaProjeto04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaProjeto04.Interfaces
{
    public interface IFornecedorRepository : IBaseRepository<Fornecedor>
    {
        Fornecedor ConsultarPorCnpj(string cnpj);
    }
}
