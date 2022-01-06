using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BMI.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Index(double w , double h , string gender ,string User)
        {

            var hight = h / 100;
            // BMI 計算，四捨五入小數第二位
            var BMI =Math.Round(Convert.ToDouble(w /( hight * hight)), 1);
           //var  BMI = w / h / h;
            if ((BMI < 19 && gender == "female") || (BMI < 20 && gender == "male"))
            {
                ViewBag.result = "體重過輕";
               // Console.WriteLine("Underweight");
            }
            if ((BMI < 19 && BMI <= 24 && gender == "female") || (BMI < 20 && BMI <= 25 && gender == "male"))
            {
                ViewBag.result = "健康體位";
                //if (BMI == 22)
                //{
                //    ViewBag.result = "健康體位";
                //  // Console.WriteLine("Perfect");
                //}
                //else
                //{
                //    ViewBag.result = "Moderate"; 
                //   // Console.WriteLine("Moderate");
                //}
            }
            if ((BMI > 24 && BMI <= 29 && gender == "female") || (BMI > 25 && BMI <= 30 && gender == "male"))
            {
                ViewBag.result = "輕度肥胖";
             // Console.WriteLine("Overweight");
            }
            if ((BMI > 29 && BMI <= 34 && gender == "female") || (BMI > 30 && BMI <= 35 && gender == "male"))
            {
                ViewBag.result = "中度肥胖";
              // Console.WriteLine("Fat");
            }
            if ((BMI > 34 && gender == "female") || (BMI > 35 && gender == "male"))
            {
                ViewBag.result = "重度肥胖";
                //Console.WriteLine("Very Fat");
            }

            ViewBag.BMI = BMI;
            ViewBag.user = User;
            return PartialView("ResultView");
        }

      
        public ActionResult Index()
        {

          

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}