using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controladores;

namespace Front
{
    public partial class MainFront : Form
    {
        public MainFront()
        {
            InitializeComponent();
            RefrescarTablaDePublicaciones();
        }

        public String GenerarId()
        {
            string nombre = TboxNombreIn.Text;
            string apellido = TboxApellidoIn.Text;

            int largo = (nombre.Length - 1);

            string id = nombre.Remove(1, largo);
            id = id + apellido;

            return id;
        }

        private void BtnCrearUsr_Click(object sender, EventArgs e)
        {
            string id = GenerarId();

            if (ControlPersona.ExistePersona(id) == false)
            {

            ControlPersona.CrearPersona(id, TboxNombreIn.Text, TboxApellidoIn.Text);

            TboxNombreIn.Clear();
            TboxApellidoIn.Clear();

            LbMensaje.Text = "Usuario creado con exito";

            RefrescarTablaDePublicaciones();
            }
            else { LbMensaje.Text = "El usuario ya existe"; }
        }
        private void RefrescarTablaDePublicaciones()
        {
            DgridPersonas.Refresh();
            DgridPersonas.DataSource = ControlPersona.Listar();        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string IdPersona = DgridPersonas.SelectedRows[0].Cells["Id"].Value.ToString();
            DialogResult resultado = MessageBox.Show(
                $"Esta seguro que quiere eliminar a {IdPersona}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                ControlPersona.EliminarPersona(IdPersona);
                RefrescarTablaDePublicaciones();
                MessageBox.Show("Persona eliminada");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string id = DgridPersonas.SelectedRows[0].Cells["Id"].Value.ToString();
            ControlPersona.ModificarNomPersona(id, TboxNombreMod.Text);
            ControlPersona.ModificarApePersona(id, TboxApellidoMod.Text);
            MessageBox.Show("Se modifico el contenido");
            RefrescarTablaDePublicaciones();
        }

        private void DgridPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TboxNombreMod.Text = DgridPersonas.SelectedRows[0].Cells["Nombre"].Value.ToString();
            TboxApellidoMod.Text = DgridPersonas.SelectedRows[0].Cells["Apellido"].Value.ToString();
        }
    }
}
