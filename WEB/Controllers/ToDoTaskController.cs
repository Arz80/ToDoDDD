using BLL.UnitOfWork;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB.ViewModels;

namespace WEB.Controllers;

public class ToDoTaskController : Controller
{
    private readonly UnitOfWork _uow;
    public ToDoTaskController(UnitOfWork uow)
    {
        _uow = uow;
    }
    // GET: ToDoTasks
    public IActionResult Index()
    {
        ToDoTaskViewModel model = new ToDoTaskViewModel
        {
            ToDoTasks = _uow.ToDoTaskRepository.Get().ToList(),
            Statuses = _uow.StatusRepository.Get().ToList(),
            Priorities = _uow.PriorityRepository.Get().ToList(),
        };
        return View(model);
    }

    public IActionResult Create()
    {
        List<Priority> allPriorities = _uow.PriorityRepository.Get().ToList();
        ViewBag.allPriorities = new SelectList(allPriorities, "Id", "Name");

        List<Status> allStatuses = _uow.StatusRepository.Get().ToList();
        ViewBag.allStatuses = new SelectList(allStatuses, "Id", "Name");

        return View();
    }

    [HttpPost]
    public IActionResult Create(ToDoTask goal)
    {
        List<Priority> allPriorities = _uow.PriorityRepository.Get().ToList();
        ViewBag.allPriorities = new SelectList(allPriorities, "Id", "Name");

        List<Status> allStatuses = _uow.StatusRepository.Get().ToList();
        ViewBag.allStatuses = new SelectList(allStatuses, "Id", "Name");

        if (ModelState.IsValid)
        {

            _uow.ToDoTaskRepository.Insert(goal);
            _uow.Save();
            return RedirectToAction("Index");
        }
        return View(goal);
    }
    public IActionResult Details(Guid id)
    {
        if (id.ToString() is null)
        {
            return NotFound();
        }
        var goal = _uow.ToDoTaskRepository.GetById(id);
        if (goal is null)
        {
            return NotFound();
        }

        return View(goal);
    }
    public IActionResult ChangeStatus(Guid id)
    {
        _uow.ToDoTaskRepository.ChangeStatus(id);
        return RedirectToAction("Index");
    }
    public IActionResult Delete(Guid id)
    {
        _uow.ToDoTaskRepository.Delete(id);
        _uow.Save();
        return RedirectToAction("Index");
    }
}
