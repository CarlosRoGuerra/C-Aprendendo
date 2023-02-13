using Microsoft.AspNetCore.Mvc;
using todo.Models;
using todo.ViewModels;

namespace todo.Controllers
{
    public class TodoController: Controller
    {
        private readonly IConfiguration _configuration;

        public TodoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
