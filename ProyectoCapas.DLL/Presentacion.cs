using ProyectoCapas.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.DAL
{
    public class Presentacion : IDatos
    {
        private readonly AppDbContext _context;
       
        public Presentacion(AppDbContext context)
        {
            _context = context;
        }

        public List<Usuario> obtenerTodos()
        {
           return _context.usuarios.ToList();
        }
        public Usuario obtenerPorId(int id)
        {
            return _context.usuarios.FirstOrDefault( p => p.Id == id);
        }
        public void actualizar(Usuario usuario)
        {
            var existente = obtenerPorId(usuario.Id);
            if (existente != null)
            {
                _context.usuarios.Update(existente);
                _context.SaveChanges();
            }
        }

        public void agregar(Usuario usuario)
        {
            _context.usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void eliminar(int id)
        {
            var usuario = obtenerPorId(id);
            if (usuario != null)
            {
                _context.usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }

        

        
    }
}
