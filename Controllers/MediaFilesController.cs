using MediaFileTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaFileTask.Controllers
{
    public class MediaFilesController : Controller
    {
        // GET: MediaFiles
        public ActionResult Index()
        {
            using(MediaFileContext db = new MediaFileContext())
            {
                return View(db.MediaFiles.ToList());
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (MediaFileContext db = new MediaFileContext())
            {
                return View(db.MediaFiles.AsNoTracking().FirstOrDefault(x => x.Id == id));
            }
        }

        public JsonResult RenameFile(RenameMedia model)
        {
            using (var context = new MediaFileContext())
            {
                /*var m = new MediaFile() { Id = model.Id };
                m.Name = model.Name;
                context.SaveChanges();
                return Json(new { Name = model.Name, JsonRequestBehavior.AllowGet });*/
                var m = context.MediaFiles.FirstOrDefault(x => x.Id == model.Id);
                if(m != null)
                {
                    m.Name = model.Name;
                }
                context.SaveChanges();
                return Json(new { Name = model.Name });
            }
        }
    }
}