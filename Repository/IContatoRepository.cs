using Altsystems.ControleDeContatos.Models;
using System.Collections.Generic;

namespace Altsystems.ControleDeContatos.Repository
{
    public interface IContatoRepository
    {
        List<Contato> BuscarTodos();
        Contato Adicionar(Contato contato);
    }
}