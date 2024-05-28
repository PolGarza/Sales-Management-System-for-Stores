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
    public partial class DEPARTAMENTO : Form
    {
        public DEPARTAMENTO()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DATAGV_DEPARTAMENTO.DataSource = LOGICA_DEPARTAMENTO.Listar();
                this.Formato_Departamento();
                this.Limpiar();
                //Con esto contamos el total de las filas que tendríamos en nuestro DATAGV
                label_total_dep.Text = "Total registros: " + Convert.ToString(DATAGV_DEPARTAMENTO.Rows.Count);
            }
            catch (Exception ex)
            {
                //Nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void Buscar()
        {

            try
            {
                DATAGV_DEPARTAMENTO.DataSource = LOGICA_DEPARTAMENTO.Buscar(TB_BUSCAR_DEP.Text);
                this.Formato_Departamento();
                label_total_dep.Text = "Total registros: " + Convert.ToString(DATAGV_DEPARTAMENTO.Rows.Count);

            }
            catch (Exception ex)
            {
                //nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }

        private void Formato_Departamento()
        {
            DATAGV_DEPARTAMENTO.Columns[0].Visible = false;
            DATAGV_DEPARTAMENTO.Columns[1].Width=100;
            DATAGV_DEPARTAMENTO.Columns[1].HeaderText= "Código";
            DATAGV_DEPARTAMENTO.Columns[2].Width =150;
            DATAGV_DEPARTAMENTO.Columns[2].HeaderText = "Nombre";
            DATAGV_DEPARTAMENTO.Columns[3].Width =80;
            DATAGV_DEPARTAMENTO.Columns[3].HeaderText = "Estado";


        }

        //Para que al insertar nuevos datos no nos salgan los datos anteriores 
        private void Limpiar()
        {
            TB_BUSCAR_DEP.Clear();
            text_ID.Clear();
            text_Nombre.Clear();
            button_insertar.Visible = true;
            button_actualizar.Visible = false;
            error_icono.Clear();

            //ACtivar/Desactivar/Eliminar
            DATAGV_DEPARTAMENTO.Columns[0].Visible = false;
            button_activar.Visible = false;
            button_desactivar.Visible = false;
            button_eliminar.Visible = false;
            CHECKB_DEP.Checked = false;
        }


        //MENSAJES
        private void Mensaje_error(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Departamento sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Mensaje_ok(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MENU_ADMINISTRADOR pantalla = new MENU_ADMINISTRADOR();
            pantalla.Show();
            this.Hide();
        }

        private void DEPARTAMENTO_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void DATAGV_DEPARTAMENTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DATAGV_DEPARTAMENTO.Columns["Seleccionar_departamento"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DATAGV_DEPARTAMENTO.Rows[e.RowIndex].Cells["Seleccionar_departamento"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void button1_buscar_departamento_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (text_Nombre.Text == string.Empty)
                {
                    this.Mensaje_error("Falta ingresar algunos datos, serán remarcados.");
                    error_icono.SetError(text_Nombre, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = LOGICA_DEPARTAMENTO.Insertar(text_Nombre.Text.Trim());
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

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabControl1.SelectedIndex = 0;
        }

        private void DATAGV_DEPARTAMENTO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                button_insertar.Visible = false;
                button_actualizar.Visible = true;
                text_ID.Text = Convert.ToString(DATAGV_DEPARTAMENTO.CurrentRow.Cells["ID"].Value);
                text_Nombre.Text = Convert.ToString(DATAGV_DEPARTAMENTO.CurrentRow.Cells["nombre_Departamento"].Value);
                tabControl1.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda -Código- o -Nombre-.");

            }
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (text_Nombre.Text == string.Empty || text_ID.Text == string.Empty)
                {
                    this.Mensaje_error("Falta ingresar algunos datos, serán remarcados.");
                    error_icono.SetError(text_Nombre, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = LOGICA_DEPARTAMENTO.Actualizar(Convert.ToInt32(text_ID.Text), text_Nombre.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.Mensaje_ok("Se actualizó de forma correcta el registro");
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

        private void CHECKB_DEP_CheckedChanged(object sender, EventArgs e)
        {

            if (CHECKB_DEP.Checked)
            {
                DATAGV_DEPARTAMENTO.Columns[0].Visible = true;
                DATAGV_DEPARTAMENTO.Columns[0].Width = 45;
                DATAGV_DEPARTAMENTO.Columns[0].HeaderText = "Select";
                button_activar.Visible = true;
                button_desactivar.Visible = true;
                button_eliminar.Visible = true;

            }
            else
            {
                DATAGV_DEPARTAMENTO.Columns[0].Visible = false;
                DATAGV_DEPARTAMENTO.Columns[0].Width = 45;
                DATAGV_DEPARTAMENTO.Columns[0].HeaderText = "Select";
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
                Opcion = MessageBox.Show("¿Realmente deseas eliminar lo seleccionado?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DATAGV_DEPARTAMENTO.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = LOGICA_DEPARTAMENTO.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.Mensaje_ok("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
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
                Opcion = MessageBox.Show("¿Realmente deseas Activar lo seleccionado?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DATAGV_DEPARTAMENTO.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = LOGICA_DEPARTAMENTO.Activar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.Mensaje_ok("Se Activó el registro: " + Convert.ToString(row.Cells[2].Value));
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
                Opcion = MessageBox.Show("¿Realmente deseas Desactivar lo seleccionado?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DATAGV_DEPARTAMENTO.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = LOGICA_DEPARTAMENTO.Desactivar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.Mensaje_ok("Se Desactivó el registro: " + Convert.ToString(row.Cells[2].Value));
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
    }
}
