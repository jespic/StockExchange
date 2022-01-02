using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BagLib;
using BagLib.Models;
using Microsoft.Extensions.Configuration;

namespace BagMVC.Controllers
{
    public class CountriesController : ApiBaseController
    {
  
        public CountriesController(IConfiguration configuration) : base(configuration)
        {
        }

        // GET: Countries
        public async Task<IActionResult> Index()
        {
            return base.View(
                await client.GetCountriesAsync()
                );
        }



        // GET: Countries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var countries = await client.GetCountryCurrencies();

            if (countries == null)
            {
                return NotFound();
            }

            return View(countries.FirstOrDefault(c => c.CountryId == id));
        }


    }
}
