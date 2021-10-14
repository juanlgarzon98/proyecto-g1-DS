using System;
using Ganaderia.App.Dominio;
using System.Linq;
using System.Collections.Generic;

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

        Ejemplares IRepositorioEjemplares.UpdateEjemplares(Ejemplares ejemplares)
        {
            var ejemplaresEncontrado = _appContext.Ejemplares.FirstOrDefault(e => e.Id == ejemplaresId);
            return ejemplares;   
        }
    } 
}