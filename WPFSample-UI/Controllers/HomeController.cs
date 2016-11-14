using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WPFSample_BL.Listados;
using WPFSample_BL.Manejadoras;
using WPFSample_Ent;

namespace WPFSample_UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ListadosBL lista = new ListadosBL();
            return View(lista.listadoPersonasBL());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return (Create(persona));
            }else
            {
                manejadoraPersonaBL miMane = new manejadoraPersonaBL();
                miMane.insertPersonaBL(persona);
                ListadosBL lista = new ListadosBL();
                return View("Index",lista.listadoPersonasBL());
            }
            
        }

        public ActionResult Delete(int id)
        {
            return View("Delete");
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            manejadoraPersonaBL miMane = new manejadoraPersonaBL();
            ListadosBL miLista = new ListadosBL();
            miMane.deletePersonaBL(id);
            return View("Index",miLista.listadoPersonasBL());
        }

        public ActionResult Edit(int id)
        {
            Persona p = new Persona();
            //No me gusta :(
            foreach (Persona pn in new ListadosBL().listadoPersonasBL())
            {
                if (pn.id == id)
                {
                    p.Nombre = pn.Nombre;
                    p.Apellidos = pn.Apellidos;
                    p.FechaNac = pn.FechaNac;
                    p.telefono = pn.telefono;
                    p.direccion = pn.direccion;
                }
            }
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Persona persona)
        {
            manejadoraPersonaBL miMane = new manejadoraPersonaBL();
            miMane.updatePersonaBL(persona);

            return View("Index",new ListadosBL().listadoPersonasBL());
        }

        public ActionResult Details(int id)
        {
            manejadoraPersonaBL miMane = new manejadoraPersonaBL();
            Persona p = miMane.selectPersonaBL(id);
            return View(p);
        }
    }
}