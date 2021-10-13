using System;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioEjemplares : IRepositorioEjemplares
    {
        private readonly AppContext _appContext;

        public RepositorioEjemplares(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioEjemplares.AddEjemplares(Ejemplares ejemplares)
        {
            _appContext.Ejemplares.Add(ejemplares);
            _appContext.SaveChanges();
        }

    } 
}