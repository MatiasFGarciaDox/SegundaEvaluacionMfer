using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPersona : Modelo
    {
        public string Id;
        public string Nombre;
        public string Apellido;

        public void GuardarPersona()
        {
            string sql = $"insert into Persona (id,nombre,apellido) values('{this.Id}','{this.Nombre}','{this.Apellido}')";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void ModificarNombrePersona()
        {
            string sql = $"update Persona set nombre ='{this.Nombre}' where id = '{this.Id}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }
        
        public void ModificarApellidoPersona()
        {
            string sql = $"update Persona set apellido ='{this.Nombre}' where id = '{this.Id}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public List<ModeloPersona> ObtenerPersonas()
        {
            List<ModeloPersona> persona = new List<ModeloPersona>();

            string sql = $"select * from Persona where eliminado = false";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                ModeloPersona p = new ModeloPersona();
                p.Id = this.Lector["id"].ToString();
                p.Nombre = this.Lector["nombre"].ToString();
                p.Apellido = this.Lector["apellido"].ToString();
                persona.Add(p);
            }
            return persona;
        }
    }
}
