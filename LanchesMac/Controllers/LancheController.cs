using LanchesMac.Repositories;
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

            var lanches = lancheRepository.Lanches;
            return View(lanches);
        }
    }
    
}

