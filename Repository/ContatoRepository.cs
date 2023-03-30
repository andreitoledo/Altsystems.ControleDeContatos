using Altsystems.ControleDeContatos.Data;
using Altsystems.ControleDeContatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace Altsystems.ControleDeContatos.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _context;

        public ContatoRepository(BancoContext bancoContext)
        {
            _context = bancoContext;
        }

        public Contato ListarPorId(int id)
        {
            return _context.Contato.FirstOrDefault(x => x.Id == id);
        }

        public List<Contato> BuscarTodos()
        {
            return _context.Contato.ToList();
        }

        public Contato Adicionar(Contato contato)
        {
            _context.Contato.Add(contato);
            _context.SaveChanges();

            return contato;
        }

        public Contato Atualizar(Contato contato)
        {
            Contato contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) throw new System.Exception("Houve um erro na atualização do contato.!");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _context.Contato.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;

        }

        public bool Excluir(int id)
        {
            Contato contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new System.Exception("Houve um erro na exclusão do contato.!");

            _context.Contato.Remove(contatoDB);
            _context.SaveChanges();

            return true;
        }
    }
}
