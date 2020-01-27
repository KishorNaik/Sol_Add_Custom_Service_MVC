using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Repository;

namespace Sol_Demo.Controllers
{
    public class DemoController : Controller
    {
        private readonly IUserRepository userRepository = null;

        public DemoController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Data = await userRepository.GetNames();

            return View();
        }
    }
}