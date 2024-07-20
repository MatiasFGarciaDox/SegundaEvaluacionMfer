﻿using System;
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
            
            ControlPersona.CrearPersona(GenerarId(), TboxNombreIn.Text, TboxApellidoIn.Text);

            TboxNombreIn.Clear();
            TboxApellidoIn.Clear();

            LbMensaje.Text = "Usuario creado con exito";

            RefrescarTablaDePublicaciones();
        }

        private void DgridPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefrescarTablaDePublicaciones()
        {
            DgridPersonas.Refresh();
            DgridPersonas.DataSource = ControlPersona.Listar();        }
    }
}
