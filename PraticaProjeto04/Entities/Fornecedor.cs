using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaProjeto04.Entities
{
    /// <summary>
    /// Classe de modelo de entidade para Fornecedor
    /// </summary>
    public class Fornecedor
    {
        //prop + 2x[tab]
        public Guid IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        //Relacionamentos -> TER-MUITOS
        public List<Produto> Produtos { get; set; }
    }
}
