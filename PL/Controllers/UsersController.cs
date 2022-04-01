using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {

            ML.Users user = new ML.Users();
            ML.Result result = BL.Users.GetAll(user);

            if (result.Correct)
            {
                user.Usuarios = result.Objects;
            }
            else
            {

            }
            return View(user);
        }
        [HttpPost]
        public ActionResult GetAll(ML.Users user)
        {
            ML.Result result = BL.Users.GetAll(user);

            if (result.Correct)
            {
                user.Usuarios = new List<object>();
                user.Usuarios = result.Objects.ToList();
            }
            else
            {
                ViewBag.Message = result.ErrorMessage;
                return PartialView("Modal");
            }
            return View(user);
        }
        [HttpGet]
        public ActionResult Form(int? Id)
        {
            ML.Users user = new ML.Users();
            if (Id == null)
            {
                return View(user);
            }
            else
            {
                ML.Result result = BL.Users.GetById(Id.Value);
                if (result.Correct)
                {
                    user = ((ML.Users)result.Object);
                    user.Usuarios = result.Objects;
                    return View(user);
                }
                else
                {
                    ViewBag.Mensaje = "No se encontro el registro " + result.ErrorMessage;
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult Form(ML.Users user)
        {
            ML.Result result = new ML.Result();
            if (user.Id == 0)
            {
                result = BL.Users.Add(user);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "El usuario se ha registrado correctamente";
                }
                else
                {
                    ViewBag.Mensaje = "El usuario no se ha registrado correctamente";
                }
            }
            else
            {
                result = BL.Users.Update(user);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "El usuario se actualizo correctamente";
                }
                else
                {
                    ViewBag.Mensaje = "El usuario no se actualizo correctamente";
                }
            }
            return PartialView("Modal");
        }
        public ActionResult Delete(int Id)
        {
            ML.Users user = new ML.Users();
            user.Id = Id;
            ML.Result result = BL.Users.Delete(user);
            if (result.Correct)
            {
                ViewBag.Mensaje = "El usuario se ha eliminado correctamente";
            }
            else
            {
                ViewBag.Mensaje = "El usuario no se ha eliminado correctamente";
            }
            return PartialView("Modal");
        }
	}
}