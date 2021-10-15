using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioEjemplares
    {
       void AddEjemplares(Ejemplares ejemplares);
       Ejemplares  AsignarVeterinarioAEjemplares(int idEjemplares, int idVeterinario);
    }
}