using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using segundoParcial.Model;
using segundoParcial.Vista;

namespace segundoParcial
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            lblBeneficiario.Hide();
            lblNombre.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (covidGobEntities db = new covidGobEntities())
            {
                lblBeneficiario.Hide();
                lblNombre.Hide();
                string dui = txtDUI.Text;
                var lista = from bene in db.Beneficiarios

                            where bene.DUI == dui
                            select new
                            {
                                Nombre = bene.Nombre
                            };


                if (lista.Count() > 0)
                {
                    lblBeneficiario.Show();
                    foreach (var i in lista)
                    {
                        lblNombre.Text = i.Nombre.ToString();
                        lblNombre.Show();
                        
                    }

                }
                else
                {
                    lblNombre.Text = "ESTE DUI NO SE ENCUENTRA REGISTRADO EN NUESTRA BASE DE DATOS";
                    lblBeneficiario.Hide();
                    lblNombre.Show();
                    txtDUI.Text = "";


                }
                
            }


        }





frmConsultas consultas = new frmConsultas();
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            consultas.ShowDialog();
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {
            
            lblBeneficiario.Hide();
            lblNombre.Hide();
        }
    }
}
