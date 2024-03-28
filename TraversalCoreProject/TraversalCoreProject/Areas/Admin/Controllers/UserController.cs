﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.GetList();
            
            return View(values);
        }
        public IActionResult DeleteUser(int id) 
        {
            var values = _appUserService.GetById(id);
            _appUserService.TDelete(values);
            return RedirectToAction("İndex"); 
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _appUserService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommendUser(int id)
        {
            _appUserService.GetList();
            return View();
        }
        public IActionResult ReservationUser(int id)
        {
            var values = _reservationService.GetListWithReservationByWaitAccepted(id);
            return View(values);
        }
    }
}
 