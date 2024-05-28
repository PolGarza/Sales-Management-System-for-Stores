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
using System.IO;// comando que nos permite copiar archivos 

namespace VENTANAS_MAD
{
    public partial class PRODUCTO_ADMINISTRAR : Form
    {
    
        public PRODUCTO_ADMINISTRAR()
        {
            InitializeComponent();
        }

          private bool Menor_cero(float valor)
        {
            return valor > 0;
        }

        private void Listar()
        {
            try
            {
                DATAGV_PRODUCTO.DataSource = LOGICA_PRODUCTO.Listar();
                //this.Formato_Departamento();
                this.Formato_producto();
                this.Limpiar();
                label_total_dep.Text = "Total productos: " + Convert.ToString(DATAGV_PRODUCTO.Rows.Count);
            }
            catch (Exception ex)
            {
                //nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {

            try
            {
                DATAGV_PRODUCTO.DataSource = LOGICA_PRODUCTO.Buscar(TB_BUSCAR_DEP.Text);
                this.Formato_producto();
                label_total_dep.Text = "Total Productos: " + Convert.ToString(DATAGV_PRODUCTO.Rows.Count);

            }
            catch (Exception ex)
            {
                //nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }

        private void Formato_producto()
        {
            //DATAGV_PRODUCTO.Columns[0].Visible = false;
            DATAGV_PRODUCTO.Columns[1].Width = 65;
            DATAGV_PRODUCTO.Columns[1].HeaderText= "ID";
            DATAGV_PRODUCTO.Columns[2].Visible = false;
            DATAGV_PRODUCTO.Columns[3].Width = 100;
            DATAGV_PRODUCTO.Columns[3].HeaderText = "Departamento";
            DATAGV_PRODUCTO.Columns[4].Width = 100;
            DATAGV_PRODUCTO.Columns[4].HeaderText = "Nombre";
            DATAGV_PRODUCTO.Columns[5].Width = 100;
            DATAGV_PRODUCTO.Columns[5].HeaderText = "Precio";
            DATAGV_PRODUCTO.Columns[6].Width = 100;
            DATAGV_PRODUCTO.Columns[6].HeaderText = "Costo";
            DATAGV_PRODUCTO.Columns[7].Width = 100;
            DATAGV_PRODUCTO.Columns[7].HeaderText = "Stock";
            DATAGV_PRODUCTO.Columns[8].Width = 100;
            DATAGV_PRODUCTO.Columns[8].HeaderText = "Descripción";
            DATAGV_PRODUCTO.Columns[9].Width = 65;
            DATAGV_PRODUCTO.Columns[9].HeaderText = "Unidad";
            DATAGV_PRODUCTO.Columns[10].Width = 45;
            DATAGV_PRODUCTO.Columns[10].HeaderText = "Estado";
            DATAGV_PRODUCTO.Columns[11].Width = 65;
            DATAGV_PRODUCTO.Columns[11].HeaderText = "Devolución";
            DATAGV_PRODUCTO.Columns[12].Width = 150;
            DATAGV_PRODUCTO.Columns[12].HeaderText = "Fecha de Ingreso";
        }

        private void Limpiar()
        {
            TB_BUSCAR_DEP.Clear();
            text_ID.Clear();
            text_Nombre.Clear();
            text_descripcion.Clear();
            tex_precio.Clear();
            text_stock.Clear();
            text_Costo.Clear();


            button_insertar.Visible = true;
            button_actualizar.Visible = false;
            error_icono.Clear();
           // this.Ruta_Destino = "";
            //this.Ruta_Destino = "";

            //ACtivar/Desactivar/Eliminar
            DATAGV_PRODUCTO.Columns[0].Visible = false;
            button_activar.Visible = false;
            button_desactivar.Visible = false;
            button_eliminar.Visible = false;
            CHECKB_DEP.Checked = false;

        }

        private void Mensaje_error(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Producto Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Mensaje_ok(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Producto Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Cargar_Departamento()
        {
            try
            {
                CB_DEPARTAMENTO.DataSource = LOGICA_DEPARTAMENTO.Seleccionar();
                CB_DEPARTAMENTO.ValueMember = "Id_Departamento";
                CB_DEPARTAMENTO.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void PRODUCTO_ADMINISTRAR_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.Cargar_Departamento();
        }

        private void button1_buscar_producto_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }



    private void button_insertar_Click(object sender, EventArgs e)
        {

            try
            {
                string Rpta = "";
                //validamos que no esten vacios nuestros campos
                if (CB_DEPARTAMENTO.Text == string.Empty || text_Nombre.Text == string.Empty || tex_precio.Text == string.Empty || CB_DEPARTAMENTO.Text == string.Empty || text_stock.Text == string.Empty)
                {
                    this.Mensaje_error("Falta ingresar algunos datos, serán remarcados.");
                    error_icono.SetError(CB_DEPARTAMENTO, "Elija un departamento.");
                    error_icono.SetError(text_Nombre, "Ingrese un nombre.");
                    error_icono.SetError(tex_precio, "Ingrese un precio.");
                    error_icono.SetError(text_stock, "Ingrese una cantidad.");
                }
                else
                {
                    bool validacion = Menor_cero(float.Parse(tex_precio.Text));

                    if (validacion)
                    {
                        Rpta = LOGICA_PRODUCTO.Insertar(Convert.ToInt32(CB_DEPARTAMENTO.SelectedValue), text_Nombre.Text.Trim(), text_descripcion.Text.Trim(), Convert.ToDecimal(tex_precio.Text), Convert.ToInt32(text_stock.Text), (CB_UnidadMedida.SelectedItem.ToString()), Convert.ToDecimal(text_Costo.Text), (CB_Devolución.SelectedItem.ToString()));
                        if (Rpta.Equals("OK"))
                        {
                            this.Mensaje_ok("Se insertó de forma correcta el registro");
                            this.Listar();
                        }
                        else
                        {
                            this.Mensaje_error(Rpta);
                        }
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

        // COMBOBOX
        private void CB_UnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            MENU_ADMINISTRADOR pantalla = new MENU_ADMINISTRADOR();
            pantalla.Show();
            this.Hide();
        }




       
        //Evento en el cual damos doble click al producto
        private void DATAGV_PRODUCTO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

               
         
                string valor = Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["devolucion"].Value);
                if (valor.Equals("True"))
                {
                    valor = "Si";
                }
                else
                {
                    valor = "No";
                }

                CB_Devolución.Text = valor;


                //string valor= Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["devolucion"].Value); ;
                this.Limpiar();
                button_actualizar.Visible = true;
                button_insertar.Visible = false;
                text_ID.Text = Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["ID"].Value);
                CB_DEPARTAMENTO.SelectedValue = Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["Id_Departamento"].Value);
                text_Nombre.Text = Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["Nombre"].Value);
                tex_precio.Text = Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["Precio_Producto"].Value);
                text_Costo.Text = Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["costo_Producto"].Value);
                CB_UnidadMedida.Text = Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["Unidad_M"].Value); //Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["Unidad_M"].Value);
                CB_Devolución.SelectedItem = Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["devolucion"].Value);
                text_stock.Text = Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["Stock"].Value);
                text_descripcion.Text = Convert.ToString(DATAGV_PRODUCTO.CurrentRow.Cells["Descripcion"].Value);
        
                TAB_PRODUCTOS.SelectedIndex = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("De doble click en otra columna porfavor" + "| Error: " + ex.Message);
            }
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {

            try
            {
                string Rpta = "";
                //validamos que no esten vacios nuestros campos
                if (CB_DEPARTAMENTO.Text == string.Empty || text_Nombre.Text == string.Empty || tex_precio.Text == string.Empty || CB_DEPARTAMENTO.Text == string.Empty || text_stock.Text == string.Empty)
                {
                    this.Mensaje_error("Falta ingresar algunos datos, serán remarcados.");
                    error_icono.SetError(CB_DEPARTAMENTO, "Elija un departamento.");
                    error_icono.SetError(text_Nombre, "Ingrese un nombre.");
                    error_icono.SetError(tex_precio, "Ingrese un precio.");
                    error_icono.SetError(text_stock, "Ingrese una cantidad.");
                }
                else
                {
                    bool validacion = Menor_cero(float.Parse(tex_precio.Text));

                    if (validacion)
                    {
                        Rpta = LOGICA_PRODUCTO.Actualizar(Convert.ToInt32(text_ID.Text), Convert.ToInt32(CB_DEPARTAMENTO.SelectedValue), text_Nombre.Text.Trim(), text_descripcion.Text.Trim(), Convert.ToDecimal(tex_precio.Text), Convert.ToInt32(text_stock.Text), (CB_UnidadMedida.Text), Convert.ToDecimal(text_Costo.Text), (CB_Devolución.Text));
                        if (Rpta.Equals("OK"))
                        {
                            this.Mensaje_ok("Se insertó de forma correcta el registro");
                            this.Listar();
                        }
                        else
                        {
                            this.Mensaje_error(Rpta);
                        }
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

        private void DATAGV_PRODUCTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DATAGV_PRODUCTO.Columns["Seleccionar_departamento"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DATAGV_PRODUCTO.Rows[e.RowIndex].Cells["Seleccionar_departamento"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void CHECKB_DEP_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECKB_DEP.Checked)
            {
                DATAGV_PRODUCTO.Columns[0].Visible = true;
                button_activar.Visible = true;
                button_desactivar.Visible = true;
                button_eliminar.Visible = true;

            }
            else
            {
                DATAGV_PRODUCTO.Columns[0].Visible = false;
                button_activar.Visible = false;
                button_desactivar.Visible = false;
                button_eliminar.Visible = false;
            }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente deseas eliminar el registro?", "Sistema de Productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    string Imagen = "";

                    foreach (DataGridViewRow row in DATAGV_PRODUCTO.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Imagen = Convert.ToString(row.Cells[9].Value);
                            Rpta = LOGICA_PRODUCTO.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.Mensaje_ok("Se eliminó el registro: " + Convert.ToString(row.Cells[5].Value));
                            
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

        private void button_desactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente deseas desactivar el producto?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DATAGV_PRODUCTO.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = LOGICA_PRODUCTO.Desactivar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.Mensaje_ok("Se desactivó el producto: " + Convert.ToString(row.Cells[5].Value));
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

        private void button_activar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente deseas desactivar el producto?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DATAGV_PRODUCTO.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = LOGICA_PRODUCTO.Activar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.Mensaje_ok("Se Activó el producto: " + Convert.ToString(row.Cells[5].Value));
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

        private void CB_DEPARTAMENTO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
