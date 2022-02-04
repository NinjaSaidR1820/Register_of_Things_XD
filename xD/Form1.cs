using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xD.Clase;

namespace xD
{
    public partial class Form1 : Form
    {

        Empledo emp = new Empledo();
        List<Empledo> miempresa = new List<Empledo>();
        Empledo MiEmpleado;
        public Form1()
        {
            InitializeComponent();

            MiEmpleado = new Empledo();

            dgvInfo.Columns.Add("Numero", "Numero");
            dgvInfo.Columns.Add("Nombre", "Nombre");
            dgvInfo.Columns.Add("Sueldo", "Sueldo");


            dgvInfo.ReadOnly = true;
            dgvInfo.AllowUserToAddRows = false;
            dgvInfo.AllowUserToDeleteRows = false;
            dgvInfo.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           

            

            emp.Numero = int.Parse(txtNumero.Text);
            emp.Nombre = txtNombre.Text;
            emp.Sueldo = double.Parse(txtSueldo.Text);


            miempresa.Add(emp);

            


            //foreach (Empledo miEmpleado in miempresa)
            //{
                dgvInfo.Rows.Add(emp.Numero,
                emp.Nombre, emp.Sueldo);
            //}



            txtNombre.Clear();
            txtNumero.Clear();
            txtSueldo.Clear();

            txtNombre.Focus();

        }

        private void btnClean_Click(object sender, EventArgs e)
        {


            txtNombre.Clear();
            txtNumero.Clear();
            txtSueldo.Clear();

            txtNombre.Focus();


            dgvInfo.Rows.Clear();
        }

        private void rbContadorActivated_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            lblCount.Visible = true;
            lblCount.Text = this.miempresa.Count.ToString();
            
        }

        private void rbContadorInactivated_CheckedChanged(object sender, EventArgs e)
        {


            lblCount.Visible = false;
            label4.Visible = false;
        }
    }
}
