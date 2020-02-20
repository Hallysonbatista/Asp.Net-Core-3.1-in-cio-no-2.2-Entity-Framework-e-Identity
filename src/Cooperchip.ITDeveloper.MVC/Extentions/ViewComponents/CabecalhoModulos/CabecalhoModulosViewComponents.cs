using System.Threading.Tasks;
using Cooperchip.ITDeveloper.MVC.Extentions.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Cooperchip.ITDeveloper.Mvc.Extentions.ViewComponents.CabecalhoModulos
{
    [ViewComponent(Name = "Cabecalho")]
    public class CabecalhoModulosViewComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string titulo, string subtitulo)
        {
            var model = new Modulo()
            {
                Titulo = titulo,
                SubTitulo = subtitulo
            };

            return View(model);
        }
    }
}
