using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Danfe.Nota;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeradorDanfe.Controllers
{
    public class DanfeController : Controller
    {
        private IHostingEnvironment _env;
        public DanfeController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            string nomeXML = "ExemploDanfe.xml";

            var webRoot = _env.WebRootPath;

            string ArquivoXML = System.IO.Path.Combine(webRoot, "xml", nomeXML);

            DanfePrintViewer model = new DanfePrintViewer(ArquivoXML);

            return View(model);
        }
    }
}
