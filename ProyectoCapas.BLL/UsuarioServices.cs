using ProyectoCapas.DAL;

namespace ProyectoCapas.BLL
{
    public class UsuarioServices
    {
        private readonly IDatos _repository;

        public UsuarioServices(IDatos repository)
        {
            _repository = repository;
        }

        public List<Usuario> ObtenerProductosDisponibles()
        {
            return _repository.obtenerTodos().Where(p => p.Id > 0).ToList();
        }
        public Usuario ObtenerProductoPorId(int id)
        {
            var usuario = _repository.obtenerPorId(id);
            if (usuario == null)
            {
                throw new KeyNotFoundException($"No se encontró un producto con ID {id}");
            }
            return usuario;
        }
        public void AgregarProducto(Usuario usuario) => _repository.agregar(usuario);

        public void ActualizarProducto(Usuario usuario) => _repository.actualizar(usuario);

        public void EliminarProducto(int id) => _repository.eliminar(id);
    }
}
