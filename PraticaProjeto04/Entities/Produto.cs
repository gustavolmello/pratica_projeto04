using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaProjeto04.Entities
{
    /// <summary>
    /// Classe de modelo de entidade para Produto
    /// </summary>
    public class Produto
    {
        //[prop] + 2x[tab]
        public Guid IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public Guid IdFornecedor { get; set; }

        //Relacionamento -> TER-1
        public Fornecedor Fornecedor { get; set; }
    }
}

