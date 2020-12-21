using System;
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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            //Evento load: se ejecuta la primera vez que se carga el formulario
            this.cargarComboEstudiantes();
        }
        private void cargarComboEstudiantes()
        {
            this.cmbCedula.DataSource = CapaDatos.PersonaDAO.GetAll();
            this.cmbCedula.DisplayMember = "estudiante";
            this.cmbCedula.ValueMember = "Cédula";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = this.cmbCedula.SelectedValue.ToString();

            CapaDatos.Persona p = new CapaDatos.Persona();
            p = CapaDatos.PersonaDAO.GetPersona(cedula);

            //cargar datos en los cuadros de texto
            this.txtCedula.Text = p.Cedula;
            this.txtApellidos.Text = p.Apellidos;
            this.txtNombres.Text = p.Nombres;

        }
    }
}
