using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundoParcial.Vista
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usu = "master";
            string contra = "123";
            if(txtUsuario.Text.Equals(usu)&& txtContraseña.Text == contra)
            {

                frmAdmi admi = new frmAdmi();
                admi.ShowDialog();
                this.Close();
                txtContraseña.Text = "";
                txtUsuario.Text = "";

            }
            else
            {
                txtContraseña.Text = "";
                txtUsuario.Text = "";
                MessageBox.Show("Usuario incorrecto");
            }

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }
    }
}
