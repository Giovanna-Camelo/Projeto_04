using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_4.Models;
using System.Diagnostics;

namespace Projeto_4.Controllers
{
    public class TarefasController : Controller
    {
        private static List<Tarefas> _tarefas = new List<Tarefas>()
    {
        new Tarefas { TarefaId= 1, TarefaName="Arrumar Projeto", TarefaDescription="Fazer as alterações no projeto", Data="10/05/2024", Status="Para fazer" },
       new Tarefas { TarefaId= 2, TarefaName="Estudar para prova", TarefaDescription="Tirar um tempo para estudar Programação prova no dia 15", Data="10/05/2024", Status="Para fazer" },
       new Tarefas { TarefaId= 3, TarefaName="Arrumar a casa", TarefaDescription="Organizar a casa", Data="8/05/2024", Status="Concluído" },
        new Tarefas {TarefaId = 4, TarefaName = "Fazer Trabalho faculdade", TarefaDescription = "Fazer o trabalho de Fenômenos", Data = "06/05/2024", Status = "Concluído"}
   };
        public IActionResult Index()
        {
            return View(_tarefas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tarefas tarefas)
        {

            if (ModelState.IsValid)
            {

                tarefas.TarefaId = _tarefas.Count > 0 ? _tarefas.Max(c => c.TarefaId) + 1 : 1;


                _tarefas.Add(tarefas);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var tarefas = _tarefas.FirstOrDefault(c => c.TarefaId == id);
            if (tarefas == null)
            {
                return NotFound();
            }

            _tarefas.Remove(tarefas);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {

            var tarefas = _tarefas.FirstOrDefault(c => c.TarefaId == id);
            if (tarefas == null)
                return NotFound();

            return View(tarefas);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var tarefas = _tarefas.FirstOrDefault(c => c.TarefaId == id);
            if (tarefas == null)
            {
                return NotFound();
            }

            return View(tarefas);
        }


        [HttpGet]
        public IActionResult Concluido()
        {
            return View(_tarefas);
        }

        [HttpGet]
        public IActionResult Fazer()
        {
            return View(_tarefas);
        }


    }


}












