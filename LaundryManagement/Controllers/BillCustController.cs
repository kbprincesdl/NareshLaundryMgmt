using LaundryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaundryManagement.Controllers
{
    public class BillCustController : Controller
    {
        // GET: BillCust

        BillCustContext db = new BillCustContext();
        public ActionResult getBillCustInfo()
        {
            return View(db.getBillCustDetails());
        }
        public ActionResult GeneratePDF()
        {
           return new Rotativa.ActionAsPdf("getBillCustInfo");
            //return new Rotativa.ActionAsPdf("GetPrint");
        }


        public ActionResult GetPrint()
        {
            return View();
        }

        public ActionResult getData()
        {
            return View(db.getBillCustDetails());
        }

    }
}