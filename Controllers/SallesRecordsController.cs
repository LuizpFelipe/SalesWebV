using Microsoft.AspNetCore.Mvc;
using SalesWebV.Services;
using System;
using System.Threading.Tasks;

namespace SalesWebV.Controllers
{
    public class SallesRecordsController : Controller
    {
        private readonly SallesRecordService _serviceSalleRecord;

		public SallesRecordsController(SallesRecordService serviceSalleRecord)
		{
			_serviceSalleRecord = serviceSalleRecord;
		}

		public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? min, DateTime? max)
        {
            if (!min.HasValue)
            {
                min = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!max.HasValue)
            {
                max = DateTime.Now;
            }
            ViewData["min"] = min.Value.ToString("yyyy-MM-dd");
            ViewData["max"] = max.Value.ToString("yyyy-MM-dd");

            var result = await _serviceSalleRecord.AsyncFindBydate(min, max);
            return View(result);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? min, DateTime? max)
        {
            if (!min.HasValue)
            {
                min = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!max.HasValue)
            {
                max = DateTime.Now;
            }
            ViewData["min"] = min.Value.ToString("yyyy-MM-dd");
            ViewData["max"] = max.Value.ToString("yyyy-MM-dd");

            var result = await _serviceSalleRecord.FindByDateGroupingAsync(min, max);
            return View(result);
        }
    }
}
