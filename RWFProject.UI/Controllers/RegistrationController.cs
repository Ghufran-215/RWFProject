using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

using RWFProject.Data.Repository;
using RWFProject.Data.Models.Domain;

namespace DapperMvcDemo.UI.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IRegistrationRepository _registrationRepository;

        public RegistrationController(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        // Loads the DisplayAll view
        public async Task<IActionResult> DisplayAll()
        {
            var registrations = await _registrationRepository.GetAllAsync();
            return View(registrations);
        }

        // Returns all registrations as JSON for AJAX
        [HttpGet]
        public async Task<IActionResult> GetRegistrations()
        {
            var registrations = await _registrationRepository.GetAllAsync();
            return Json(registrations);
        }

        // In RegistrationController.cs
        public IActionResult Details()
        {
            var model = new Registration(); // an empty but non-null model
            return View(model);
        }






        // Loads the Details view for a specific registration
        //public async Task<IActionResult> Details(int id)
        // {
        ////   var registration = await _registrationRepository.GetByIdAsync(id);
        //if (registration == null)
        //{
        //   return NotFound();
        //}

        //return View(registration);
        //}
    }
}
