namespace Tienda.Repositorio
{
    public class RepositorioGeneral<TModel>(CarritoContext contexto) : OperacionesBase<TModel, CarritoContext>(contexto) where TModel : class
    {

    }
}
