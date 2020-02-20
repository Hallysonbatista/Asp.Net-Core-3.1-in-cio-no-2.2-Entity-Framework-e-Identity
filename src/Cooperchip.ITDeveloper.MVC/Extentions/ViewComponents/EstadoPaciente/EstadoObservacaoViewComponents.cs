using Cooperchip.ITDeveloper.Data.ORM;
using Cooperchip.ITDeveloper.MVC.Extentions.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.MVC.Extentions.ViewComponents.EstadoPaciente
{
    public class EstadoObservacaoViewComponents : ViewComponent
    {
        private readonly ITDeveloperDbContext _context;
        public EstadoObservacaoViewComponents(ITDeveloperDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var totalGeral = Util.TotalReg(_context);
            decimal totalEstado = Util.GetNumRegEstado(_context, "Observações");
            decimal progress = totalEstado * 100 / totalGeral;
            var prct = progress.ToString("F1");
            var model = new ContadorEstadopaciente()
            {
                Titulo = " Observação",
                Parcial = (int)totalEstado,
                Percentual = prct,
                ClassContainer = "panel panel-default tile panelClose panelRefresh",
                IconeLg = "l-banknote",
                IconeSm = "fa fa-arrow-circle-o-down s20 mr5 pull-left",
                Progess = progress
            };
            return View(model);
        }
    }
}
