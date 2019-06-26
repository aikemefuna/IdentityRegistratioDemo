using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityRegistrationDemo.Domain.RequestModels;
using IdentityRegistrationDemo.Domain.ResponseModels;
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

                TempData["EmptyForm"] = "Cannot submit an empty form.";
                return RedirectToAction("Create");
            }
            if (!_citizenService.IsExist(citizenRequest.BVN))
            {
                // TODO: Add insert logic here
                var createdUser = await _citizenService.CreateAsync(citizenRequest);
                if (createdUser == null)
                {


                }
                TempData["CreatedSuccess"] = "Congratulations your application was succesfull your National Identification number wil be sent to you shortly.";
                return RedirectToAction("Index");

            }

            else
            {
                TempData["ExistingUser"] = "Sorry User already enrolled.";
                return RedirectToAction("Index");
            }

        }

        public IActionResult GetUserDetails()
        {
            return View();
        }


        //fetch user details fom database.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetUserDetails(CitizenResponse citizenResponse)
        {
            if (citizenResponse.BVN == 0)
            {
                TempData["EmptyUserDetails"] = "Please input your bvn to continue.";
                return View("GetUserDetails");
            }
            var citizenExist = _citizenService.IsExist(citizenResponse.BVN);
            if (citizenExist)
            {
                var userDetails = await _citizenService.SelectByBvnAsync(citizenResponse.BVN);
                TempData["UserDetails"] = "Congratulations you have been enrolled, view your Enrollment data below.";
                return View("EnrollmentDetails", userDetails);

            }
            TempData["Failed"] = "Sorry you have not been enrolled";
            return RedirectToAction("Index");



        }
    }
}