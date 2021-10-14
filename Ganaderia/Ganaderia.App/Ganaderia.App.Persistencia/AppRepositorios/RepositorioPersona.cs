using System;
using Ganaderia.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioPersona.AddPersona(Persona persona)
        {
            _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
        }

    } 
}