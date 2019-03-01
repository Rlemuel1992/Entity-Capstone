using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity_Capstone.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Contact()
		{

			return View();
		}

		public ActionResult Courses()
		{
			return View();
		}

		public ActionResult Java()
		{
			return View();
		}

		public ActionResult CSharp()
		{
			return View();
		}

		public ActionResult FrontEnd()
		{
			return View();
		}
		[Authorize]
		public ActionResult SignUp()
		{
			return View();
		}

	}
}