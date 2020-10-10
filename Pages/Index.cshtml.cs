using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using envitech.Pages.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace envitech.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public JsonData jsonData { get; set; }
        [BindProperty]
        public string selectedMonitorType { get; set; }
        [BindProperty]
        public string selectedMonitor { get; set; }


        public void OnGet()
        {
            //Deserialize Json file.
            string TempPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Legends.json");

            string jsonFromFile;
            using (var reader = new StreamReader(TempPath))
            {
                jsonFromFile = reader.ReadToEnd();
                jsonData = JsonConvert.DeserializeObject<JsonData>(jsonFromFile);
            }
        }

        public void OnPost(string monitorType, string monitor)
        {
            selectedMonitorType = monitorType;
            selectedMonitor = monitor;
            this.OnGet();
        }

    }
}
