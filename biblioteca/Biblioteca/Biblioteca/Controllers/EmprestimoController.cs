using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class EmprestimoController : Controller
    {
        readonly private ApplicationDbContext _db;

        public EmprestimoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<emprestimoModel> emprestimos = _db.Emprestimos;
            return View(emprestimos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
    public IActionResult Cadastrar(emprestimoModel emprestimoModel)
        {
            if(ModelState.IsValid)
            {
                _db.Emprestimos.Add(emprestimoModel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Editar(emprestimoModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Update(emprestimo);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(emprestimo);
        }
        [HttpPost]
        public IActionResult Excluir(emprestimoModel emprestimo)
        {
            if (emprestimo == null)
            {
                return NotFound();
            }
            _db.Emprestimos.Remove(emprestimo);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id ==0)
            {
                return NotFound();
            }

            emprestimoModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);
            if (emprestimo == null) 
            {
                return NotFound();
            }

            return View(emprestimo);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            emprestimoModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);
            if (emprestimo == null)
            {
                return NotFound();
            }

            return View(emprestimo);
        }


    }
}

