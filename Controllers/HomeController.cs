using HomeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using practice.Models;
using System.Diagnostics;

namespace HomeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private DB_Entities _db = new DB_Entities();

        private readonly DB_Entities _db;

        public HomeController(DB_Entities db)
        {

            _db = db;
        }

        public IActionResult Index()
        {
            List<States> statesList = _db.lstStates.ToList();
            ViewBag.statesList = new SelectList(statesList, "StateID", "StateName");
            ViewBag.districtList = new SelectList("", "DistrictID", "DistrictName");
            ViewBag.VillageList = new SelectList("", "VillageID", "VillageName");

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public JsonResult Register([FromBody] HouseModel house)
        {

            _db.HouseInfo.Add(house);
            _db.SaveChanges();


            //adomethods obj = new adomethods();
            //obj.SaveHouseDetails(house);

            return Json(new { result = "success", message = "Data Saved successfully" });
        }

        [HttpPost]
        public IActionResult getDistricts([FromBody] string stateId)
        {
            int id = Convert.ToInt32(stateId);
            List<Districts> districtsList = _db.lstDistricts.Where(s => s.StateID == id).ToList();
            ViewBag.districtList = new SelectList(districtsList, "DistrictID", "DistrictName");

            //return View();
            return Json(new { result = districtsList, message = "Get successfully" });
        }

        [HttpPost]
        public IActionResult getVillages([FromBody] string VillageId)
        {
            int id = Convert.ToInt32(VillageId);
            List<Villages> villageList = _db.lstVillages.Where(s => s.VillageID == id).ToList();
            ViewBag.VillageList = new SelectList(villageList, "VillageID", "VillageName");

            return Json(new { result = villageList, message = "Get successfully" });
        }

    }
}