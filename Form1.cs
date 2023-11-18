using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//librerias
using System.Data.OleDb;
using System.IO;
using System.Windows;


namespace PryMendozaTpFinal
{
    public partial class FrmPrincipal : Form
    {
        ConexionBD objaccesoBD;
        public FrmPrincipal()
        {
            InitializeComponent();
            objaccesoBD = new ConexionBD();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //conexion a base de datos a mostrar estado de conexion
            ConexionBD objAccespBD = new ConexionBD();
            objAccespBD.ConectarBaseDatos();
            LblEstadoDeConexion.Text = objAccespBD.EstadoDeConexion;

            //mostrar datos en grilla 
            objAccespBD.TraerDatos(DgvEmpleado);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCargarDatos_Click(object sender, EventArgs e)
        {
            FrmCargarDatos frmnuevo = new FrmCargarDatos();
            frmnuevo.Show();
            this.Hide();
        }
    }
}
