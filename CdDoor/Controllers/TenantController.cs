using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YourNest.Controllers
{
    public class TenantController : Controller
    {
        //
        // GET: /Tenant/

        public ActionResult myPaymentsPartial()
        {
            DataSet ds = new DataSet();
           
            DataTable dt = new DataTable();
            dt.TableName = "dueAmount";
            dt.Columns.Add("Amount");
            dt.Columns.Add("Due date");

            DataRow dr=dt.NewRow();
            dr["Amount"] = "7000";
            dr["Due Date"] = "21 July 2017";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["Amount"] = "3000";
            dr1["Due Date"] = "21 Aug 2017";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["Amount"] = "6000";
            dr2["Due Date"] = "21 Sep 2017";
            dt.Rows.Add(dr2);

            ViewBag.dueAmount = dt;
            DataTable dt2 = new DataTable();

            dt2.TableName = "paidAmount";
            dt2.Columns.Add("Amount");
            dt2.Columns.Add("Paid date");
            
            DataRow dr3 = dt2.NewRow();
            dr3["Amount"] = "7000";
            dr3["Paid date"] = "21 July 2017";
            dt2.Rows.Add(dr3);
            DataRow dr4 = dt2.NewRow();
            dr4["Amount"] = "3000";
            dr4["Paid date"] = "21 Aug 2017";
            dt2.Rows.Add(dr4);
            DataRow dr5 = dt2.NewRow();
            dr5["Amount"] = "6000";
            dr5["Paid date"] = "21 Sep 2017";
            dt2.Rows.Add(dr5);
            ds.Tables.Add(dt2);

            ViewBag.PaidAmount = dt2;

            return View();
        }

        public ActionResult serviceRequestPartial()
        {
            return View();
        }

    }
}
