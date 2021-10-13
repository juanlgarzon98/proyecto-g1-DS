using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioSolicitud
    {
       void AddSolicitud(Solicitud solicitud);
    }
}