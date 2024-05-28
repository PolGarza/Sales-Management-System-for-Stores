using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA_MAD;


namespace VENTANAS_MAD
{
    public partial class DEVOLUCIONES : Form
    {
        public DEVOLUCIONES()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DGV_DEVOLUCION.DataSource = LOGICA_LISTAR_DEV.Listar();
             
                this.Limpiar();
                //Con esto contamos el total de las filas que tendríamos en nuestro DATAGV
                //label_total_dep.Text = "Total registros: " + Convert.ToString(DGVDetalle.Rows.Count);
            }
            catch (Exception ex)
            {
                //Nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void Listar2()
        {
            try
            {
                DGV_DEVOLUCION.DataSource = LOGICA_LISTAR_DEV.Listar();

                this.Limpiar();
                //Con esto contamos el total de las filas que tendríamos en nuestro DATAGV
                //label_total_dep.Text = "Total registros: " + Convert.ToString(DGVDetalle.Rows.Count);
            }
            catch (Exception ex)
            {
                //Nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void Insertar(int IdVEN, int IDPROC, string Nombre, int CANT,decimal  Precio, decimal import, string unidad, string TIPO)
        {
            try
            {
                DGV_DEVOLUCION.DataSource = LOGICA_DEVOLUCION.Insertar(IdVEN, IDPROC, Nombre, CANT, Precio, import, unidad, TIPO);
                this.Mensaje_ok("Se insertó de forma correcta el registro");
                this.Limpiar();
                //Con esto contamos el total de las filas que tendríamos en nuestro DATAGV
                //label_total_dep.Text = "Total registros: " + Convert.ToString(DGVDetalle.Rows.Count);
            }
            catch (Exception ex)
            {
                //Nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void Limpiar()
        {
            //ACtivar/Desactivar/Eliminar
            CHECKB_DEP.Checked = false;
        }

        private void Mensaje_error(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Departamento sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Mensaje_ok(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void DEVOLUCIONES_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void CHECKB_DEP_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


 
            int IdVEN, IDPROC, CANT;
            string Nombre, unidad;
            decimal Precio, import;
            IdVEN = Convert.ToInt32(DGV_DEVOLUCION.CurrentRow.Cells["Id_Venta"].Value);
            IDPROC = Convert.ToInt32(DGV_DEVOLUCION.CurrentRow.Cells["Id_Producto"].Value);
            Nombre = Convert.ToString(DGV_DEVOLUCION.CurrentRow.Cells["Producto1"].Value);
            CANT = Convert.ToInt32(DGV_DEVOLUCION.CurrentRow.Cells["Cantidad"].Value);
            Precio = Convert.ToDecimal(DGV_DEVOLUCION.CurrentRow.Cells["Precio"].Value);
            import = Convert.ToDecimal(DGV_DEVOLUCION.CurrentRow.Cells["Importe"].Value);
            unidad = Convert.ToString(DGV_DEVOLUCION.CurrentRow.Cells["Unidad_Medida"].Value);
            string tipo ="Merma";

           this.Insertar(IdVEN, IDPROC, Nombre, CANT, Precio, import, unidad, tipo);

            this.Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int IdVEN, IDPROC, CANT;
            string Nombre, unidad;
            decimal Precio, import;
            IdVEN = Convert.ToInt32(DGV_DEVOLUCION.CurrentRow.Cells["Id_Venta"].Value);
            IDPROC = Convert.ToInt32(DGV_DEVOLUCION.CurrentRow.Cells["Id_Producto"].Value);
            Nombre = Convert.ToString(DGV_DEVOLUCION.CurrentRow.Cells["Producto1"].Value);
            CANT = Convert.ToInt32(DGV_DEVOLUCION.CurrentRow.Cells["Cantidad"].Value);
            Precio = Convert.ToDecimal(DGV_DEVOLUCION.CurrentRow.Cells["Precio"].Value);
            import = Convert.ToDecimal(DGV_DEVOLUCION.CurrentRow.Cells["Importe"].Value);
            unidad = Convert.ToString(DGV_DEVOLUCION.CurrentRow.Cells["Unidad_Medida"].Value);
            string tipo = "Cambio";

            this.Insertar(IdVEN, IDPROC, Nombre, CANT, Precio, import, unidad, tipo);

            this.Listar();
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarDetalle(int Idproduc, string nombreproduct, decimal precioproduct, decimal importe, string uniM, bool devo)
        {

          
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {

         
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BUTTOM_BUSCAR_C_Click(object sender, EventArgs e)
        {
            this.Listar2();

        }

        private void button5_volver_Click(object sender, EventArgs e)
        {
            MENU_ADMINISTRADOR pantalla = new MENU_ADMINISTRADOR();
            pantalla.Show();
            this.Hide();
        }
    }
}
