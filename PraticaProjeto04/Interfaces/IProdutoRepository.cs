using PraticaProjeto04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaProjeto04.Interfaces
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        List<Produto> ConsultarPorPreco(decimal precoMin, decimal precoMax);
        List<Produto> ConsultarPorData(DateTime dataMin, DateTime dataMax);
    }
}
