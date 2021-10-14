using System;
using Ganaderia.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext;

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            _appContext.Veterinario.Add(veterinario);
            _appContext.SaveChanges();
        }

    } 
}