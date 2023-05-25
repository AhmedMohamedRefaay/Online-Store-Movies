using Microsoft.AspNetCore.Mvc;
using Online__Store_Movies.Models.Domain;
using Online__Store_Movies.Repository.Abstract;

namespace Online__Store_Movies.Controllers
{
    public class GenereController:Controller
    {
        private readonly IGenereService _genereService;
        public GenereController(IGenereService genereService)
        {
            _genereService = genereService;
        }

        public IActionResult Index()
        {
            var all = _genereService.GetAll();
            return View(all.ToList());
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Genere genere) 
        {

            if (!ModelState.IsValid)
                return View(genere);
            _genereService.Add(genere);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int Id)
        {
            var model=_genereService.GetById(Id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Genere genere)
        {

            if (!ModelState.IsValid)
                return View(genere);
            _genereService.Update(genere);
            return RedirectToAction(nameof(Index));
        }
    }
}
