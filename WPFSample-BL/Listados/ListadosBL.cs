using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSample_Ent;
using WPFSample_DAL;

namespace WPFSample_BL.Listados
{
    public class ListadosBL
    {
        public List<Persona> listadoPersonasBL()
        {
            List<Persona> devolver;
            ListadosDAL listDAL = new ListadosDAL();
            devolver = listDAL.listadoPersonas();
            return devolver;
        }
    }
}
