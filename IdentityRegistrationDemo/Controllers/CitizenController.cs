using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityRegistrationDemo.Domain.RequestModels;
using IdentityRegistrationDemo.Domain.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityRegistrationDemo.Controllers
{
    public class CitizenController : Controller
    {
        private readonly ICitizenService _citizenService;

        public CitizenController(ICitizenService citizenService)
        {
            _citizenService = citizenService;
        }
   

        public ActionResult Index()
        {
            return View();
        }
      
        // GET: Citizen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Citizen/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CitizensRequest citizenRequest)
        {
            if (citizenRequest == null)
            {
                throw new ArgumentNullException(nameof(citizenRequest));
            }
                // TODO: Add insert logic here
              var createdUser =  await _citizenService.CreateAsync(citizenRequest);
            if (createdUser ==null)
            {
                return null;
            }
            TempData["CreatedSuccess"] = "Congratulations your application was succesfull your National Identification number wil be sent to you shortly.";
            return RedirectToAction("Index");
            
        
        }

        
    }
}