using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using segundoParcial.Model;

namespace segundoParcial.Vista
{
    public partial class frmAdmi : Form
    {
        public frmAdmi()
        {
            InitializeComponent();
        }

        private void frmAdmi_Load(object sender, EventArgs e)
        {
            CargarDatos();
            txtNombre.Enabled = false;
            txtDUI.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        public void CargarDatos()
        {
            using (covidGobEntities db = new covidGobEntities())
            {
                var lista = from bene in db.Beneficiarios
                            select new 
                            { ID = bene.id,
                              NOMBRE = bene.Nombre,
                              DUI = bene.DUI
                            };
                dgvBeneficiarios.DataSource = lista.ToList();


            }
            
        }
        public void limpiar()
        {
            txtDUI.Text = "";
            txtNombre.Text = "";
            txtNombre.Enabled = false;
            txtDUI.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            txtNombre.Enabled = true;
            txtDUI.Enabled  = true;
            btnGuardar.Enabled = true;
        }

        public Beneficiarios B = new Beneficiarios();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
               if (txtDUI.Text != "" && txtNombre.Text != "")
                {
                    using (covidGobEntities db = new covidGobEntities())
                    {
                        B.Nombre = txtNombre.Text;
                        B.DUI = txtDUI.Text;
                        db.Beneficiarios.Add(B);
                        db.SaveChanges();
                        CargarDatos();
                        limpiar();
                    }
                }
        }

        private void dgvBeneficiarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dgvBeneficiarios.CurrentRow.Cells[1].Value.ToString();
            string dui = dgvBeneficiarios.CurrentRow.Cells[2].Value.ToString();
            txtDUI.Enabled = true;
            txtNombre.Enabled = true;
            txtNombre.Text = nombre;
            txtDUI.Text = dui;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (covidGobEntities db = new covidGobEntities())
            {
                String id = dgvBeneficiarios.CurrentRow.Cells[0].Value.ToString();
                int ID = int.Parse(id);
                B = db.Beneficiarios.Where(VerificarId => VerificarId.id == ID).First();
                B.Nombre = txtNombre.Text;
                B.DUI = txtDUI.Text;
                db.Entry(B).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                CargarDatos();
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (covidGobEntities db = new covidGobEntities())
            {
                string id = dgvBeneficiarios.CurrentRow.Cells[0].Value.ToString();
                int ID = int.Parse(id);
                B = db.Beneficiarios.Find(ID);
                db.Beneficiarios.Remove(B);
                db.SaveChanges();
                CargarDatos();
                limpiar();
            }
                
        }
    }
}
