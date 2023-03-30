using Altsystems.ControleDeContatos.Data;
using Altsystems.ControleDeContatos.Models;

namespace Altsystems.ControleDeContatos.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Contato Adicionar(Contato contato)
        {
            _bancoContext.Contato.Add(contato);
            _bancoContext.SaveChanges();

            return contato;
        }

    }
}
