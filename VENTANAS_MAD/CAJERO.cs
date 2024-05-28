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
    public partial class CAJERO : Form
    {
        private string emailant;

        public CAJERO()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DATAGV_CAJERO.DataSource = LOGICA_CAJERO.Listar();
                this.Formato_Cajero();
                this.Limpiar();
                //Con esto contamos el total de las filas que tendríamos en nuestro DATAGV
                label_total_dep.Text = "Total registros: " + Convert.ToString(DATAGV_CAJERO.Rows.Count);
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
                DateTime fecha_inicial = Convert.ToDateTime(dateTimeInicio.Text);
                DateTime fecha_final = Convert.ToDateTime(dateTimeFin.Text);


                DATAGV_CAJERO.DataSource = LOGICA_CAJERO.Buscar(TB_BUSCAR_CAJERO.Text, fecha_inicial, fecha_final);
                this.Formato_Cajero();
                label_total_dep.Text = "Total registros: " + Convert.ToString(DATAGV_CAJERO.Rows.Count);

            }
            catch (Exception ex)
            {
                //nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }

        private void Formato_Cajero()
        {
            DATAGV_CAJERO.Columns[0].Visible = false;
            DATAGV_CAJERO.Columns[1].Width = 50;
            DATAGV_CAJERO.Columns[1].HeaderText = "ID";
            DATAGV_CAJERO.Columns[2].Width = 170;
            DATAGV_CAJERO.Columns[2].HeaderText = "Nombre";
            DATAGV_CAJERO.Columns[3].Width = 120;
            DATAGV_CAJERO.Columns[4].Width = 120;
            DATAGV_CAJERO.Columns[4].HeaderText = "Email";
            DATAGV_CAJERO.Columns[5].Width = 100;
            DATAGV_CAJERO.Columns[5].HeaderText = "Fecha Nacimiento";
            DATAGV_CAJERO.Columns[6].Width = 100;
            DATAGV_CAJERO.Columns[6].HeaderText = "Fecha Ingreso";
            DATAGV_CAJERO.Columns[7].Width = 50;
            DATAGV_CAJERO.Columns[7].HeaderText = "Estado";
        }

        //Para que al insertar nuevos datos no nos salgan los datos anteriores 
        private void Limpiar()
        {
            TB_BUSCAR_CAJERO.Clear();

            text_Nombre.Clear();
            text_CURP.Clear();
            text_Email.Clear();
            text_Clave.Clear();

            button_insertar.Visible = true;
            button_actualizar.Visible = false;
            error_icono.Clear();

            //ACtivar/Desactivar/Eliminar
            DATAGV_CAJERO.Columns[0].Visible = false;
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

        private void CAJERO_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void button1_buscar_administrador_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DATAGV_CAJERO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DATAGV_CAJERO.Columns["Seleccionar_departamento"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DATAGV_CAJERO.Rows[e.RowIndex].Cells["Seleccionar_departamento"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (text_Nombre.Text == string.Empty || text_CURP.Text == string.Empty || text_Email.Text == string.Empty || text_Clave.Text == string.Empty)
                {
                    this.Mensaje_error("Falta ingresar algunos datos, serán remarcados.");
                    error_icono.SetError(text_Nombre, "Ingrese un nombre.");
                    error_icono.SetError(text_CURP, "Ingrese un usuario.");
                    error_icono.SetError(text_Email, "Ingrese un email.");
                    error_icono.SetError(text_Clave, "Ingrese una clave.");
                }
                else
                {
                    Rpta = LOGICA_CAJERO.Insertar(text_Nombre.Text.Trim(), text_CURP.Text.Trim(), text_Email.Text.Trim(), text_Clave.Text.Trim(), dateTime_FechaN.Text.Trim());
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DATAGV_CAJERO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                button_actualizar.Visible = true;
                button_insertar.Visible = false;
                text_ID.Text = Convert.ToString(DATAGV_CAJERO.CurrentRow.Cells["ID"].Value);
                text_Nombre.Text = Convert.ToString(DATAGV_CAJERO.CurrentRow.Cells["NombreCajero"].Value);
                text_CURP.Text = Convert.ToString(DATAGV_CAJERO.CurrentRow.Cells["CURP"].Value);
                this.emailant = Convert.ToString(DATAGV_CAJERO.CurrentRow.Cells["EmailCajero"].Value);
                text_Email.Text = Convert.ToString(DATAGV_CAJERO.CurrentRow.Cells["EmailCajero"].Value);
                dateTime_FechaN.Text = Convert.ToString(DATAGV_CAJERO.CurrentRow.Cells["FechaNam"].Value);
                dateTime_FechaI.Text = Convert.ToString(DATAGV_CAJERO.CurrentRow.Cells["FechaIngr"].Value);
                tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (text_ID.Text == string.Empty || text_Nombre.Text == string.Empty || text_Email.Text == string.Empty)
                {
                    this.Mensaje_error("Falta ingresar algunos datos, serán remarcados.");
                    error_icono.SetError(text_Nombre, "Ingrese un nombre.");
                    error_icono.SetError(text_Email, "Ingrese un email.");
                }
                else
                {
                    Rpta = LOGICA_CAJERO.Actualizar(Convert.ToInt32(text_ID.Text), text_Nombre.Text.Trim(), text_CURP.Text.Trim(), this.emailant, text_Email.Text.Trim(), text_Clave.Text.Trim(), dateTime_FechaN.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.Mensaje_ok("Se actualizo de forma correcta el registro");
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

        private void CHECKB_DEP_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECKB_DEP.Checked)
            {
                DATAGV_CAJERO.Columns[0].Visible = true;
                button_activar.Visible = true;
                button_desactivar.Visible = true;
                button_eliminar.Visible = true;

            }
            else
            {
                DATAGV_CAJERO.Columns[0].Visible = false;
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

                    foreach (DataGridViewRow row in DATAGV_CAJERO.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = LOGICA_CAJERO.Eliminar(Codigo);

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

        private void button_desactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente deseas desactivar lo seleccionado?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DATAGV_CAJERO.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = LOGICA_CAJERO.Desactivar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.Mensaje_ok("Se desactivo el registro: " + Convert.ToString(row.Cells[2].Value));
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
                Opcion = MessageBox.Show("¿Realmente deseas activado lo seleccionado?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DATAGV_CAJERO.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = LOGICA_CAJERO.Activar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.Mensaje_ok("Se activado el registro: " + Convert.ToString(row.Cells[2].Value));
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

        private void button1_Click(object sender, EventArgs e)
        {
            MENU_ADMINISTRADOR pantalla = new MENU_ADMINISTRADOR();
            pantalla.Show();
            this.Hide();
        }
    }
}
