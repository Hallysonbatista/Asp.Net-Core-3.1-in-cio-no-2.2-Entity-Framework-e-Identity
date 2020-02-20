using Cooperchip.ITDeveloper.Data.ORM;
using Cooperchip.ITDeveloper.MVC.Extentions.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.MVC.Extentions.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name ="EstadoCritico")]
    public class EstadoCriticoViewComponents : ViewComponent
    {
        private readonly ITDeveloperDbContext _context;
        public EstadoCriticoViewComponents(ITDeveloperDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var totalGeral = Util.TotalReg(_context);
            decimal totalEstado = Util.GetNumRegEstado(_context, "Crítico");
            decimal progress = totalEstado * 100 / totalGeral;
            var prct = progress.ToString("F1");
            var model = new ContadorEstadopaciente()
            {
                Titulo = "Estado Crítico",
                Parcial = (int)totalEstado,
                Percentual = prct,
                ClassContainer = "panel panel-success tile panelClose panelRefreshh",
                IconeLg = "l-basic-geolocalize-05",
                IconeSm = "fa fa-arrow-circle-o-up s20 mr5 pull-left",
                Progess = progress
            };
            return View(model);
        }
    }
}
