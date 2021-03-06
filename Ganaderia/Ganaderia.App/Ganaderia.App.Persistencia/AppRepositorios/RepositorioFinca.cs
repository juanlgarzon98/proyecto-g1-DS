using System;
using Ganaderia.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioFinca : IRepositorioFinca
    {
        private readonly AppContext _appContext;

        public RepositorioFinca(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioFinca.AddFinca(Finca finca)
        {
            _appContext.Finca.Add(finca);
            _appContext.SaveChanges();
        }

    } 
}