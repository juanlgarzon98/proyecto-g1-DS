using System;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly AppContext _appContext;

        public RepositorioHistoriaClinica(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioHistoriaClinica.AddHistoriaClinica(HistoriaClinica historiaClinica)
        {
            _appContext.HistoriaClinica.Add(historiaClinica);
            _appContext.SaveChanges();
        }

    } 
}