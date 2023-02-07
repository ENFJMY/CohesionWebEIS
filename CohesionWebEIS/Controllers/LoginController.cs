using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CohesionWebEIS.Models.DTO;
using CohesionWebEIS.Models.DAO;

namespace CohesionWebEIS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        // https://localhost:44389/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string id, string password)
        {
            CommonDAO dao = new CommonDAO();
            UserDTO currentUser = dao.LoginCheck(id, password);
            if (currentUser != null)
            {
                Session["userInfo"] = currentUser;
                Session["userName"] = currentUser.USER_NAME;
                Session["userDepartment"] = currentUser.USER_DEPARTMENT;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult Logout()
        {
            Session["userInfo"] = null;
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}