using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioHistoriaClinica
    {
       void AddHistoriaClinica(HistoriaClinica historiaClinica);
    }
}