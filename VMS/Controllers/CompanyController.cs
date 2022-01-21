using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VMS.Models;
using VMS.Utilities;

namespace VMS.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public async Task <ActionResult> Index()
        {
            try
            {
                CompanyModel cm = new CompanyModel();
                var model = await cm.GetCompanies(true);
                return View(model);
            }
            catch (Exception ex)
            {
                ErrorLogging.Add(ex.Message, ex.InnerException == null ? null : ex.InnerException.Message, DateTime.Now, "admin", "Index", "Index");
                throw;
            }
        }
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Create(CompanyModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int result = await model.Create();
                    if (result == 1)
                    {
                        
                        return Json(new 
                        { 
                            Status = "Success",
                            Message = "Company has been successfully saved",
                            URL = "/Company/Index",
                            JsonRequestBehavior.AllowGet 
                        });
                    }
                    else if (result == 0)
                    {
                        return Json(new { Status = "Error", Message = "Company already exsist!!", JsonRequestBehavior.AllowGet });
                    }
                    else
                    {
                        return Json(new { Status = "Error", Message = "Company has not been successfully saved.Please try again", JsonRequestBehavior.AllowGet });
                    }
                }
                else
                {
                    return Json(new { Status = "Error" });
                }
            }
            catch (Exception ex)
            {

                ErrorLogging.Add(ex.Message, ex.InnerException == null ? null : ex.InnerException.Message, DateTime.Now, "admin", "Index", "Index");
                return RedirectToAction("ErrorPage", "Error", new ModelExceptionPage { errorMessage = ex.Message });
            }
        }
    }

}


