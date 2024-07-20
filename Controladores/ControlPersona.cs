using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Modelos;

namespace Controladores
{
    public class ControlPersona
    {
        public static void CrearPersona(string id,string nombre,string apellido)
        {
            ModeloPersona persona = new ModeloPersona();
            persona.Id = id;
            persona.Nombre = nombre;
            persona.Apellido = apellido;

            persona.GuardarPersona();
        }

        public static void EliminarPersona(string id)
        {
            ModeloPersona persona = new ModeloPersona();
            persona.Id = id;
            persona.EliminarPersona();
        }

        public static void ModificarNomPersona(string id, string nombre)
        {
            ModeloPersona persona = new ModeloPersona();
            persona.Id = id;
            persona.Nombre = nombre;
            persona.ModificarNombrePersona();
        }

        public static void ModificarApePersona(string id,string apellido)
        {
            ModeloPersona persona = new ModeloPersona();
            persona.Id = id;
            persona.Apellido = apellido;
            persona.ModificarApellidoPersona();
        }

        public static DataTable Listar()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));

            ModeloPersona persona = new ModeloPersona();
            foreach (ModeloPersona p in persona.ObtenerPersonas())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = p.Id;
                fila["Nombre"] = p.Nombre;
                fila["Apellido"] = p.Apellido;

                tabla.Rows.Add(fila);
            }
            return tabla;
        }
    }
}
