using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class ModeloPersona : Modelo
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
    }
}
