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
		public int insertPersonaDAL(Persona persona){
			int i=0;

            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.Nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
            miComando.Parameters.Add("@fechaNac", System.Data.SqlDbType.DateTime).Value = persona.FechaNac;
            miComando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.direccion;
            miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.telefono;

            try
            {
				miCon.openConnection();

                miComando.CommandText = "Insert Into personas(nombre,apellidos,fechaNac,direccion,telefono) VALUES "
                    +"(@nombre,@apellidos,@fechaNac,@direccion,@telefono)";
                miComando.Connection = miCon.connection;
                i=miComando.ExecuteNonQuery();
				
			}catch(SqlException){
                throw;
            }
			finally{
				miCon.closeConnection();
			}
			return i;
		}


        public int deletePersonaDAL(int id)
        {
            int delete = 0;
            SqlCommand miComando = new SqlCommand();

            try
            {
                miCon.openConnection();
                miComando.Connection = miCon.connection;
                miComando.Parameters.Add("@id",System.Data.SqlDbType.Int).Value=id;

                miComando.CommandText = "Delete From personas where IdPersona=@id";
                miComando.Connection = miCon.connection;
                delete = miComando.ExecuteNonQuery();

            }
            catch (SqlException) {
                throw;
            }
            finally
            {
                miCon.closeConnection();
            }

            return delete;
        }
	}
}
