using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSample_Ent;

namespace WPFSample_DAL.Manejadoras
{
	public class manejadoraPersonaDAL{
		
		private MyConnection miCon;
		
		public manejadoraPersonaDAL(){
			miCon=new MyConnection();
		
		}
		/// <summary>
        /// NO ACABADA
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
		/*public int insertPersonaDAL(Persona persona){
			int i;
			try{
				miCon.openConnection();
				SqlCommand miComando=new SqlCommand();
				miComando.Parameters.Add("@nombre",System.Data.SqlDbType.VarChar).Value=persona.Nombre;
				miComando.Parameters.Add("@apellidos",System.Data.SqlDbType.VarChar).Value=persona.Apellidos;
				miComando.Parameters.Add("@fechaNac",System.Data.SqlDbType.DateTime).Value=persona.FechaNac;
				miComando.Parameters.Add("@direccion",System.Data.SqlDbType.VarChar).Value=persona.direccion;
				miComando.Parameters.Add("@telefono",System.Data.SqlDbType.VarChar).Value=persona.telefono;

				
			}catch(SqlException){}
			finally{
				miCon.closeConnection();
			}
			return i;
		}*/
	}
}
