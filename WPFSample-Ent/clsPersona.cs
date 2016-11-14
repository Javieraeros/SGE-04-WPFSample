using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample_Ent
{
    public class Persona
    {
        [Required]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:dd/mm/yyyy}")]
        public DateTime FechaNac { get; set; }

        public int id { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }

        public Persona(){
            id = 0;
            Nombre = "";
            Apellidos = "";
            FechaNac = new DateTime();
            direccion = "Mi casa";
            telefono = "teléeefono";
            }

        public Persona(int parId,string nombre, string apellidos, DateTime fechaNac,
            string direccion,string telefono)
        {
            this.id = parId;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNac = fechaNac;
            this.telefono = telefono;
            this.direccion = direccion;
        }
    }
}
