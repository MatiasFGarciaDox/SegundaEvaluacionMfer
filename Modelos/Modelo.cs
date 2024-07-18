using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelos
{
    public abstract class Modelo
    {
        public string IP;
        public string NombreBD;
        public string NombreDeUsuario;
        public string Contraseña;

        public MySqlConnection Conexion;
        public MySqlCommand Comando;
        public MySqlDataReader Lector;

        public Modelo()
        {
            this.IP = "127.0.0.1";
            this.NombreBD = "PersonasBD";
            this.Contraseña = "1234";
            this.NombreDeUsuario = "root";

            this.Conexion = new MySqlConnection(
                $"server={this.IP};" +
                $"user={this.NombreDeUsuario};" +
                $"password={this.Contraseña};" +
                $"database={this.NombreBD};"
                );

            this.Conexion.Open();

            this.Comando = new MySqlCommand();
            this.Comando.Connection = this.Conexion;
        }
    }
}
