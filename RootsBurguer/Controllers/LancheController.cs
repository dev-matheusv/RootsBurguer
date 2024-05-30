using Microsoft.AspNetCore.Mvc;
using RootsBurguer.Migrations;
using RootsBurguer.Repositories.Interfaces;
using RootsBurguer.ViewModels;

namespace RootsBurguer.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            // ViewData["Titulo"] = "Todos os Lanches";
            // ViewData["Data"] = DateTime.Now;

            // var totalLanches = lanches.Count();
            // ViewBag.Total = "Total de Lanches: ";
            // ViewBag.TotalLanches = totalLanches;

            //----------------------------------------------------------------------//

            // var lanches = _lancheRepository.Lanches;
            // return View(lanches);
            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _lancheRepository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lancheListViewModel);
        }
    }
}
