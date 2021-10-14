using System;
using Ganaderia.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioSolicitud : IRepositorioSolicitud
    {
        private readonly AppContext _appContext;

        public RepositorioSolicitud(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioSolicitud.AddSolicitud(Solicitud solicitud)
        {
            _appContext.Solicitud.Add(solicitud);
            _appContext.SaveChanges();
        }

    } 
}