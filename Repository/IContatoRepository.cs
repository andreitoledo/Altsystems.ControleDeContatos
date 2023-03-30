using Altsystems.ControleDeContatos.Models;
using System.Collections.Generic;

namespace Altsystems.ControleDeContatos.Repository
{
    public interface IContatoRepository
    {
        Contato ListarPorId(int id);
        List<Contato> BuscarTodos();
        Contato Adicionar(Contato contato);
        Contato Atualizar(Contato contato);
    }
}