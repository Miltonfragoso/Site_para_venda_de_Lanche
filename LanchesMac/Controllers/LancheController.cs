using LanchesMac.Repositories;
using LanchesMac.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository lancheRepository;
        private readonly ICategoriaRepository categoriaRepository;

        public LancheController(ILancheRepository lancheRepository, 
                                ICategoriaRepository categoriaRepository)
        {
            this.lancheRepository = lancheRepository;
            this.categoriaRepository = categoriaRepository;
        }



        public IActionResult List()
        {
            ViewBag.Lanche = "Lanches";
            ViewData["Categoria"] = "Categoria";

            //var lanches = lancheRepository.Lanches;
            //return View(lanches);

            var lanchesListViewModel = new LanchesListViewModel();
            lanchesListViewModel.Lanches = lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);
        }
    }
    
}

