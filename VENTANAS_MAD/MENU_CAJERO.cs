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
    public partial class MENU_CAJERO : Form
    {
        public int IdCajero;
        public string NombreCajero;
        public bool EstadoCajero;

        private DataTable DtDetalle = new DataTable();

        public MENU_CAJERO()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            
        }

        private void Buscar()
        {

            

        }

        private void Formato_Departamento()
        {
         
        }

        private void Limpiar()
        {
            //TB_BUSCAR_DEP.Clear();
            //TxtIdCajero.Clear();
            //textNombreCajero.Clear();
            TxtSerieComprobante.Clear();
            TX_NUM_C.Clear();
            //text_ID.Clear();
            TxtTotalSubtotal.Text = "0.00";
            TxtTotalDescuento.Text = "0.00";
            TxtTotal.Text = "0.00";
           // DtDetalle.Clear();

            //ACtivar/Desactivar/Eliminar
            buttonanular.Visible = false;
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




        private void CrearTabla()
        {
            this.DtDetalle.Columns.Add("Id_Producto", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("Precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("Descuento", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("Importe", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("Unidad_Medida", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("Devolucion", typeof(bool));
            // this.DtDetalle.Columns.Add("Devolucion", System.Type.GetType("System.String"));
            DGVDetalle.DataSource = this.DtDetalle;

 
            DGVDetalle.Columns[0].ReadOnly = true;
            DGVDetalle.Columns[1].ReadOnly = true;
            DGVDetalle.Columns[2].ReadOnly = true;
            DGVDetalle.Columns[3].ReadOnly = true;
            DGVDetalle.Columns[4].ReadOnly = true;
            DGVDetalle.Columns[5].ReadOnly = true;
            DGVDetalle.Columns[6].ReadOnly = true;
            DGVDetalle.Columns[7].ReadOnly = true;
        
        }




        private void MENU_CAJERO_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CrearTabla();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INICIO pantalla1 = new INICIO();
            pantalla1.Show();
            this.Hide();
        }

        private void CboComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TX_NOMBRE_C_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void DGVDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVDetalle.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DGVDetalle.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void BUTTOM_BUSCAR_C_Click(object sender, EventArgs e)
        {
            VISTA_CAJERO frm = new VISTA_CAJERO();
            frm.ShowDialog();
            TX_NUM_C.Text = Convert.ToString(VARIABLES.IdCajero);
            TX_NOMBRE_C.Text = VARIABLES.NombreCajero;

        }

        private void TX_NUM_C_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculo_total()
        {
            decimal Total = 0;
            decimal SubTotal = 0;
            if (DGVDetalle.Rows.Count == 0)
            {
                Total = 0;
            }
            else
            {
                foreach (DataRow FilaTemp in DtDetalle.Rows)
                {
                    Total = Total + Convert.ToDecimal(FilaTemp["importe"]);
                }
            }

          
            TxtTotal.Text = Total.ToString("#0.00#");
            TxtTotalSubtotal.Text = SubTotal.ToString("#0.00#");
            TxtTotalDescuento.Text = (Total - SubTotal).ToString("#0.00#");
        }

        private void AgregarDetalle(int Idproduc, string nombreproduct, decimal precioproduct, decimal importe, string uniM, bool devo)
        {

            bool Agregar = true;
            foreach (DataRow FilaTemp in DtDetalle.Rows)
            {
                if (Convert.ToInt32(FilaTemp["ID_pRODUCTO"]) == Idproduc)
                {
                    Agregar = false;
                    this.Mensaje_error("El producto ya ha sido agregado");
                }
            }
            if (Agregar)
            {
                DataRow Fila = DtDetalle.NewRow();
                Fila["id_Producto"] = Idproduc;
                Fila["producto"] = nombreproduct;
            
                Fila["cantidad"] = 1;
                Fila["precio"] = precioproduct;
                Fila["descuento"] = 0;
                Fila["Unidad_Medida"] = uniM;
                Fila["importe"] = importe;
                Fila["devolucion"] = devo;
                //Fila["devolucion"] = devolucion;
                this.DtDetalle.Rows.Add(Fila);
                this.calculo_total();
            }
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable Tabla = new DataTable();
                    Tabla = LOGICA_PRODUCTO.BuscarNombre(TxtCodigo.Text.Trim());
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.Mensaje_error("No esiste producto con ese nombre.");
                    }
                    else
                    {
                        this.AgregarDetalle(Convert.ToInt32(Tabla.Rows[0][0]), Convert.ToString(Tabla.Rows[0][1]), Convert.ToDecimal(Tabla.Rows[0][2]), Convert.ToDecimal(Tabla.Rows[0][3]), Convert.ToString(Tabla.Rows[0][4]), Convert.ToBoolean(Tabla.Rows[0][5]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBuscarrProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DVG_PRODUCTO.DataSource = LOGICA_PRODUCTO.BuscarVenta(textBox2.Text.Trim());
                //this.FormatoArticulos();
                //LblTotalArticulos.Text = "Total Registros: " + Convert.ToString(DVG_PRODUCTO.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblTotalArticulos_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrarArticulos_Click(object sender, EventArgs e)
        {

        }

        private void BtnFiltrarArticulos_Click(object sender, EventArgs e)
        {

        }

        private void TxtBuscarArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void DVG_PRODUCTO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdArticulo, cant;
            string  Nombre, unidad;
            decimal Precio, import;
            bool dev;
       
            IdArticulo = Convert.ToInt32(DVG_PRODUCTO.CurrentRow.Cells["ID"].Value);
            Nombre = Convert.ToString(DVG_PRODUCTO.CurrentRow.Cells["Nombre"].Value);
            //cant = Convert.ToInt32(DVG_PRODUCTO.CurrentRow.Cells["Cantidad"].Value);
            Precio = Convert.ToDecimal(DVG_PRODUCTO.CurrentRow.Cells["Precio_producto"].Value);
            import = Convert.ToDecimal(DVG_PRODUCTO.CurrentRow.Cells["Precio_producto"].Value);
            unidad = Convert.ToString(DVG_PRODUCTO.CurrentRow.Cells["Unidad"].Value);
            dev = Convert.ToBoolean(DVG_PRODUCTO.CurrentRow.Cells["Devoucion"].Value);
           

            this.AgregarDetalle( IdArticulo, Nombre, Precio, import, unidad, dev);

        
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DVG_PRODUCTO_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TX_NUM_C.Text == string.Empty || TxtSerieComprobante.Text == string.Empty || DtDetalle.Rows.Count == 0)
                {
                    this.Mensaje_error("Falta ingresar algunos datos, serán remarcados.");
                    error_icono.SetError(TX_NUM_C, "Seleccione un cajero.");
                 
                    error_icono.SetError(TxtSerieComprobante, "Ingrese el numero del comprobante.");
                    error_icono.SetError(DGVDetalle, "Debe tener almenos un detalle.");
                }
                else
                {
                    Rpta = LOGICA_VENTA.Insertar(Convert.ToInt32(TX_NUM_C.Text), (CB_CAJAS.SelectedItem.ToString()), Convert.ToInt32(TxtSerieComprobante.Text), Convert.ToDecimal(TxtTotal.Text.Trim()), DtDetalle);
                    if (Rpta.Equals("OK"))
                    {
                        this.Mensaje_ok("Se insertó de forma correcta el registro");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.Mensaje_error(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DVG_PRODUCTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CHECKB_DEP_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECKB_DEP.Checked)
            {
                DGVDetalle.Columns[0].Visible = true;
                buttonanular.Visible = true;
            }
            else
            {
                DGVDetalle.Columns[0].Visible = false;
                buttonanular.Visible = false;
            }
        }

        private void buttonanular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas anular el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DGVDetalle.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = LOGICA_VENTA.Anular(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.Mensaje_ok("Se anuló el registro: " + Convert.ToString(row.Cells[6].Value) + "-" + Convert.ToString(row.Cells[7].Value));
                            }
                            else
                            {
                                this.Mensaje_error(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGVDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Para poder editar la cantidad y el precio 
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            string Producto = Convert.ToString(Fila["producto"]);//serán iguales a lo que tengan en las celdas
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            int Stock = Convert.ToInt32(Fila["stock"]);
            decimal Precio = Convert.ToInt32(Fila["precio"]);
            decimal Descuento = Convert.ToInt32(Fila["Descuento"]);
            if (Cantidad > Stock)
            {
                Cantidad = Stock;
                this.Mensaje_error("La cantidad de venta del articulo " + Producto + " supera el stock disponible " + Stock);
                Fila["cantidad"] = Cantidad;
            }
            Fila["importe"] = (Precio * Cantidad) - Descuento;
            //bool Devolucion = Convert.ToBoolean(Fila["devolucion"]);
            this.calculo_total();
        }

        private void DGVDetalle_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Para poder editar la cantidad y el precio 
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            string Producto = Convert.ToString(Fila["producto"]);//serán iguales a lo que tengan en las celdas
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            //int Stock = Convert.ToInt32(Fila["stock"]);
            decimal Precio = Convert.ToInt32(Fila["precio"]);
            decimal Descuento = Convert.ToInt32(Fila["Descuento"]);

            Fila["importe"] = (Precio * Cantidad) - Descuento;
            //bool Devolucion = Convert.ToBoolean(Fila["devolucion"]);
            this.calculo_total();
        }

        private void DGVDetalle_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVDetalle_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            //Para poder editar la cantidad y el precio 
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            string Producto = Convert.ToString(Fila["producto"]);//serán iguales a lo que tengan en las celdas
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            //int Stock = Convert.ToInt32(Fila["stock"]);
            decimal Precio = Convert.ToInt32(Fila["precio"]);
            decimal Descuento = Convert.ToInt32(Fila["Descuento"]);

            Fila["importe"] = (Precio * Cantidad) - Descuento;
            //bool Devolucion = Convert.ToBoolean(Fila["devolucion"]);
            this.calculo_total();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DGVDetalle.DataSource = LOGICA_PRODUCTO.BuscarNombre(TxtCodigo.Text.Trim());
                //this.FormatoArticulos();
                //LblTotalArticulos.Text = "Total Registros: " + Convert.ToString(DVG_PRODUCTO.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
