using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Tienda.Repositorio
{
    public class OperacionesBase <TModel , TContext>(TContext context)
        where TModel : class
        where TContext : CarritoContext
    {
        protected readonly TContext _context = context;

        public async Task<TModel> Crear(TModel model)
        {
            try
            {
                _context.Set<TModel>().Add(model);
                await _context.SaveChangesAsync();
                return model;
            }
            catch (DbUpdateException ex)
            {
                var inner = ex.InnerException?.Message;
                throw new Exception($"Error al guardar cambios: {inner ?? ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado: {ex.Message}", ex);
            }

        }

        public async Task<bool> Editar(TModel model)
        {
            _context.Set<TModel>().Update(model);
            await _context.SaveChangesAsync();
            return true;
        }

        
        public async Task<bool> Eliminar(TModel model)
        {
            _context.Set<TModel>().Remove(model);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<TModel> ConsultarRegistro(Expression<Func<TModel, bool>> filtro)
        {
            return await _context.Set<TModel>().FirstAsync(filtro);
        }

        public async Task<List<TModel>> ConsultarLista(Expression<Func<TModel, bool>>? filtro = null)
        {
            var query = filtro == null ? _context.Set<TModel>() : _context.Set<TModel>().Where(filtro);
            return await query.ToListAsync();
        }
    }
}
