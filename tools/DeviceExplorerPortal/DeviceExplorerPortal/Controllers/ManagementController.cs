namespace DeviceExplorerPortal.Controllers
{
    using System;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Models;

    public class ManagementController : Controller
    {
        public async Task<ActionResult> List()
        {
            var devicesProcessor = new DevicesProcessor();
            return View("List", await devicesProcessor.GetDevices());
        }

        public ActionResult ListGrid([DataSourceRequest]DataSourceRequest request)
        {
            var devicesProcessor = new DevicesProcessor();
            var result = Json(devicesProcessor.GetDevices().Result.ToDataSourceResult(request));
            return result;
        }

        public ActionResult CopyConnectionString(string id)
        {
            return View();
        }

        public ActionResult CreateDevice()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateDevice(DeviceCreation device)
        {
            try
            {
                var devicesProcessor = new DevicesProcessor();
                await devicesProcessor.CreateDevice(device);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult GenerateDeviceKeys()
        {
            var updatedDeviceCreation = new DeviceCreation
            {
                PrimaryKey = DevicesProcessor.GeneratePrimaryKey(),
                SecondaryKey = DevicesProcessor.GenerateSecondaryKey()
            };
            return Json(updatedDeviceCreation);
        }

        [HttpPost]
        public ActionResult GenerateDeviceId()
        {
            return Json("device" + Guid.NewGuid());
        }
    }
}
