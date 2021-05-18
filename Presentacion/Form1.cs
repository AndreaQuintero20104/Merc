using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Application.Exit();
            System.Environment.Exit(1);
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            GestorUsuarios gsUsuarios = new GestorUsuarios();

            string cedula = txtCedula.Text;
            string contrasena = txtContraseña.Text;

            if (gsUsuarios.iniciarSesion(cedula,contrasena))
            {
                MessageBox.Show("Ingreso Correcto");
                this.Hide();
                FormularioDisponibilidadCita cita = new FormularioDisponibilidadCita();
                cita.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
