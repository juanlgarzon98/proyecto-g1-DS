using System;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioVacunas : IRepositorioVacunas
    {
        private readonly AppContext _appContext;

        public RepositorioVacunas(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioVacunas.AddVacunas(Vacunas vacunas)
        {
            _appContext.Vacunas.Add(vacunas);
            _appContext.SaveChanges();
        }

    } 
}