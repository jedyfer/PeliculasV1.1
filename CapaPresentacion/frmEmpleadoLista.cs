using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmEmpleadoLista : Form
    {
        EmpleadoCN objEmp = new EmpleadoCN();
        ClienteCN objCli = new ClienteCN();

        AvalaCN objAva = new AvalaCN();

        public frmEmpleadoLista()
        {
            InitializeComponent();
            paneles();
            llenarAvalas();
        }

        private void paneles()
        {
            pnlCliente.Visible = false;
            pnlEmpleado.Visible = false;
        }

        private void llenarAvalas()
        {
            cmbAvala.DataSource = objAva.LlenarAvalas();

            cmbAvala.DisplayMember = "cliCodigo";
            cmbAvala.ValueMember = "clitelefono";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objEmp.ListaEmpleado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objCli.ListaCliente();
        }

        private void frmEmpleadoLista_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpleadoCE objCE = new EmpleadoCE();

            objCE.empCodigo = txtCodigoEmp.Text;
            objCE.emp_Apellidos = txtApellidosEmp.Text;
            objCE.emp_Nombres = txtNombresEmp.Text;
            objCE.empDireccion = txtDireccionEmp.Text;
            objCE.emp_lugar = txtLugarEmp.Text;
            objCE.empTelefono = txtTelefonoEmp.Text;
            objCE.empE_mail = txtEmailEmp.Text;
            objCE.emp_feching = Convert.ToDateTime(txtFechingEmp.Text);
            objCE.empFechNac = Convert.ToDateTime(txtFecnaEmp.Text);
            objCE.empSueldo = Convert.ToInt32(txtSueldoEmp.Text);

            objEmp.NuevoEmpleado(objCE);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientesCE objCE = new ClientesCE();

            objCE.cliCodigo = txtCodigoCli.Text;
            objCE.cliApellidos = txtApellidosCli.Text;
            objCE.cliNombres = txtNombreCli.Text;
            objCE.cliGenero = cmbGeneroCli.Text;
            objCE.cliFechNac = Convert.ToDateTime(txtFechanacCli.Text);
            objCE.cliDireccion = txtDireccionCli.Text;
            objCE.cliLugar = txtLugarCli.Text;
            objCE.cliEmail = txtEmailCli.Text;
            objCE.cliFechInsc = Convert.ToDateTime(txtFechingCli.Text);
            objCE.cliAvala = cmbAvala.Text;

            objCli.NuevoCliente(objCE);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            paneles();
            pnlEmpleado.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            paneles();
            pnlCliente.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoCli.Text = "";
            txtApellidosCli.Text = "";
            txtNombreCli.Text = "";
            cmbGeneroCli.Text = "";
            txtFechanacCli.Text = "";
            txtDireccionCli.Text = "";
            txtLugarCli.Text = "";
            txtEmailCli.Text = "";
            txtFechingCli.Text = "";
            cmbAvala.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCodigoEmp.Text = "";
            txtApellidosEmp.Text = "";
            txtNombresEmp.Text = "";
            txtDireccionEmp.Text = "";
            txtLugarEmp.Text = "";
            txtTelefonoEmp.Text = "";
            txtEmailEmp.Text = "";
            txtFechingEmp.Text = "";
            txtFecnaEmp.Text = "";
            txtSueldoEmp.Text = "";
        }
    }
}
