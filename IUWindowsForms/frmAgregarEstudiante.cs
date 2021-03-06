﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForms
{
    public partial class frmAgregarEstudiante : Form
    {
        public frmAgregarEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Faltaría agregar validaciones
            try
            {
                CapaDatos.Persona persona = new CapaDatos.Persona();
                persona.Cedula = this.txtCedula.Text;
                persona.Apellidos = this.txtApellidos.Text;
                persona.Nombres = this.txtNombres.Text;
                persona.Sexo = this.cmbSexo.Text;
                persona.FechaNacimiento = dtFechaNacimiento.Value;
                persona.Correo = this.txtCorreo.Text;
                persona.Estatura = int.Parse( this.txtEstatura.Text);
                persona.Peso =Decimal.Parse( this.txtPeso.Text);

                int x = CapaDatos.PersonaDAO.crear(persona);
                if (x > 0)
                    MessageBox.Show("Registro agregado con éxito...");
                else
                    MessageBox.Show("No se pudo agregar el registro...");
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
