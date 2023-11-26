using FiapStore.Entity;
using FiapStore.Interface;
using Microsoft.EntityFrameworkCore;

namespace FiapStore.Repository
{
    public class EFUsuarioRepository : EFRepository<Usuario>, IUsuarioRepository
    {
        public Usuario ObterComPedidos(int id)
        {
            return _context.Usuario
                 .Include(u => u.Pedidos)
                 .FirstOrDefault(u => u.Id == id);
        }
    }
}
