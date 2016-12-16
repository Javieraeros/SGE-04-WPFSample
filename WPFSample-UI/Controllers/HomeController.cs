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
        /// <summary>
        /// Carga la página principal
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ListadosBL lista = new ListadosBL();
            return View(lista.listadoPersonasBL());
        }

        /// <summary>
        /// Carga la página de crear persona
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Guarda una persona en la base de datos cuando se le da a submit
        /// </summary>
        /// <param name="persona">Persona a guardar. La recoge de los input de la vista de editar</param>
        /// <returns></returns>
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
                return RedirectToAction("Index");
            }
            
        }

        /// <summary>
        /// Confirmación de borrar a persona
        /// </summary>
        /// <param name="id">id de la persona que queremos borrar</param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            Persona p = new Persona();
            manejadoraPersonaBL miMane = new manejadoraPersonaBL();
            p=miMane.selectPersonaBL(id);
            return View("Delete",p);
        }

        /// <summary>
        /// Borrado de persona
        /// </summary>
        /// <param name="id">Id de la persona a borrar</param>
        /// <returns></returns>
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            manejadoraPersonaBL miMane = new manejadoraPersonaBL();
            miMane.deletePersonaBL(id);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Edición de persona
        /// </summary>
        /// <param name="id">Id de la persona que vamos a editar</param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            Persona p = new Persona();
            manejadoraPersonaBL miMane = new manejadoraPersonaBL();
            p = miMane.selectPersonaBL(id);
            
            return View(p);
        }

        /// <summary>
        /// Confirmación de la edición de persona y guardado en la base de datos
        /// </summary>
        /// <param name="persona">Persona YA EDITADA</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return (Edit(persona.id));
            }else
            {
                manejadoraPersonaBL miMane = new manejadoraPersonaBL();
                miMane.updatePersonaBL(persona);

            }

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Detalles de la persona
        /// No muy útil debido a que nuestra pantalla principal ya nos muestgra todos los detalles
        /// de dicha persona
        /// </summary>
        /// <param name="id">Id de la persona que queremos saber sus detalles</param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            manejadoraPersonaBL miMane = new manejadoraPersonaBL();
            Persona p = miMane.selectPersonaBL(id);
            return View(p);
        }
    }
}