﻿using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Drawing.Charts;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.GetList());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        public IActionResult GetById(int DestinationId)
        {
            var values = _destinationService.GetById(DestinationId);
            var jsonvalues = JsonConvert.SerializeObject(values);
            return Json(jsonvalues);
        }
        //public IActionResult GetById(int DesninationId)
        //{


        //    var value = _destinationService.GetById(DesninationId);
        //    if (value == null)
        //    {

        //        return StatusCode(400, "Tur Bulunamadı");
        //    }

        //    var serivalues = JsonConvert.SerializeObject(value);

        //    return Json(serivalues);


        //}


        public IActionResult DeleteCity(int id)
            {
            var values = _destinationService.GetById(id);
            if (values == null)
            {
                return BadRequest();
            }
               
                _destinationService.TDelete(values);

                return NoContent();
            }

            public IActionResult UpdateCity(Destination destination)
            {
                _destinationService.TUpdate(destination);
                var v = JsonConvert.SerializeObject(destination);
                return Json(v);
            }




        
    }
}

