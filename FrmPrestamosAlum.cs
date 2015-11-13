using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Control_de_Laboratorio
{
    public partial class FrmPrestamosAlum : Form
    {
        Conexion c = new Conexion();
        SqlConnection cn;
        
        public FrmPrestamosAlum()
        {
            InitializeComponent();
            c.MostrarCañones(dtg_Cañones);
            c.MostrarPrestamo(db_Prestamo);
            c.MostrarAlumnos(dtg_Alumnos);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Txt_NoControl.TextLength == 8)
            {
                bool success = false;

                SqlTransaction LaTransaccion = null;

                int Valor_Retornado = 0;

                try
                {
                    cn = new SqlConnection("Data Source=.;Initial Catalog=Control_del_laboratorio;Integrated Security=True");
                    cn.Open();

                    LaTransaccion = cn.BeginTransaction(System.Data.IsolationLevel.Serializable);

                    SqlCommand cmd = new SqlCommand("proc_insert_prestamo", cn, LaTransaccion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();

                   
                    cmd.Parameters.AddWithValue("@numero_cañon", Convert.ToInt32(Txt_NoCañon.Text));
                    cmd.Parameters.AddWithValue("@numero_de_alumno", Convert.ToInt32(Txt_NoControl.Text));
                    cmd.Parameters.AddWithValue("@observaciones", cmb_observaciones.SelectedItem);
                    cmd.Parameters.AddWithValue("@fecha_prestamo", dTp_Fecha.Value);
                    cmd.Parameters.AddWithValue("@Hora_prestamo", cmb_Horaprestamo.SelectedItem);
                    cmd.Parameters.AddWithValue("@Hora_entrega", cmb_Horaentrega.SelectedItem);

                    SqlParameter ValorRetorno = new SqlParameter("@comprobacion", SqlDbType.Int);
                    ValorRetorno.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(ValorRetorno);

                    cmd.ExecuteNonQuery();

                    Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);

                    if (Valor_Retornado == 1)
                        success = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Checar el Formulario", "Error en la Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (success)
                    {
                        LaTransaccion.Commit();
                        cn.Close();
                        MessageBox.Show("Persona guardada\nsatisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        c.MostrarPrestamo(db_Prestamo);
                        Txt_NoCañon.Text = "";
                        Txt_NoControl.Text = "";
                        cmb_Horaentrega.Text = "";
                        cmb_Horaprestamo.Text = "";
                        cmb_observaciones.Text = "";

                    }
                    else
                    {

                        LaTransaccion.Rollback();
                        cn.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Por favor poner 8 digitos en Numero Control");
            }






            //if (Txt_NoCañon.Text == "" || Txt_NoControl.Text == "" || cmb_observaciones.Text == "" || cmb_Horaprestamo.Text == "" || cmb_Horaentrega.Text == null)
            //{
            //    MessageBox.Show("Por favor ingrese los Datos necesarios para Prestamo");
            //}
            //else
            //{
            //    MessageBox.Show(c.insertarPrestamo(Convert.ToInt32(Txt_NoCañon.Text), Convert.ToInt32(Txt_NoControl.Text), cmb_observaciones.Text, dTp_Fecha.Text, cmb_Horaprestamo.Text, cmb_Horaentrega.Text));
            //    c.MostrarPrestamo(db_Prestamo);
            //    Txt_NoCañon.Text = "";
            //    Txt_NoControl.Text = "";
            //    cmb_Horaentrega.Text = "";
            //    cmb_Horaprestamo.Text = "";
            //    cmb_observaciones.Text = "";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( Txt_NoControl.Text == "")
            {
                MessageBox.Show("Por favor ingrese el Numero Control para Entregar Cañon");
            }
            else
            {
                MessageBox.Show(c.BorrarPrestamo(Convert.ToInt32(Txt_NoControl.Text)));
                c.MostrarPrestamo(db_Prestamo);
                Txt_NoCañon.Text = "";
                Txt_NoControl.Text = "";
                cmb_Horaentrega.Text = "";
                cmb_Horaprestamo.Text = "";
                cmb_observaciones.Text = "";
            }
        }
    }
}
