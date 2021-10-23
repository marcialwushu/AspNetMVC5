using DevIO.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Produtos
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorid);

        Task<IEnumerable<Produto>> ObterProdutosFornecedores();

        Task<Produto> ObterProdutoFornecedor(Guid id); 
    }
}
