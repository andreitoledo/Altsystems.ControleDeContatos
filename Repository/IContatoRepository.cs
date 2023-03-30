using Altsystems.ControleDeContatos.Models;

namespace Altsystems.ControleDeContatos.Repository
{
    public interface IContatoRepository
    {
        Contato Adicionar(Contato contato);
    }
}