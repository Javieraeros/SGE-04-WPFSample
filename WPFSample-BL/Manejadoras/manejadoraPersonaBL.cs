using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSample_DAL.Manejadoras;
using WPFSample_Ent;

namespace WPFSample_BL.Manejadoras
{
    public class manejadoraPersonaBL
    {
        public int insertPersonaBL(Persona persona)
        {
            manejadoraPersonaDAL miManejadora = new manejadoraPersonaDAL();
            return miManejadora.insertPersonaDAL(persona);
        }

        public int deletePersonaBL(int id)
        {
            manejadoraPersonaDAL miManejadora = new manejadoraPersonaDAL();
            return miManejadora.deletePersonaDAL(id);
        }

        public int updatePersonaBL(Persona persona)
        {
            manejadoraPersonaDAL miManejadora = new manejadoraPersonaDAL();
            return miManejadora.updatePersonaDAL(persona);
        }

        public Persona selectPersonaBL(int id)
        {
            manejadoraPersonaDAL miManejadora = new manejadoraPersonaDAL();
            return miManejadora.selectPersonaDAL(id);
        }
    }
}
