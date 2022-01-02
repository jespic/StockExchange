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
    public class CurrenciesController : ApiBaseController
    {

        public CurrenciesController(IConfiguration configuration) : base(configuration)
        {
        }

        // GET: Currencies
        public async Task<IActionResult> Index()
        {
            return View(await client.GetCurrencies());
        }

        // GET: Currencies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currency = await client.GetCurrencies();
            if (currency == null)
            {
                return NotFound();
            }

            return View(currency.FirstOrDefault(c => c.CurrencyId == id));
        }
    }
}
