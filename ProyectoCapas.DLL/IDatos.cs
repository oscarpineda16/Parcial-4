using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.DAL
{
    public interface IDatos
    {
        List<Usuario> obtenerTodos();
        Usuario obtenerPorId(int id);
        void agregar (Usuario usuario);
        void actualizar (Usuario usuario);
        void eliminar (int  id);
    }
}
