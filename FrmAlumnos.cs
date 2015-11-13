using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Laboratorio
{
    public partial class Frm_Alumnos : Form
    {
        Conexion c = new Conexion();
        public Frm_Alumnos()
        {
            InitializeComponent();
            c.MostrarAlumnos(db_Alumnos);
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            if (Txt_NoControl.TextLength == 8)
            {
                if (Txt_NoControl.Text == "" || Txt_Nombre.Text == "" || Cmb_Carrera.Text == "")
                {
                    MessageBox.Show("Porfavor Ingrese Numero Control, Nombre y Carrera para insertar");
                }
                else
                {
                    MessageBox.Show(c.insertarAlumno(Convert.ToInt32(Txt_NoControl.Text), Txt_Nombre.Text, Cmb_Carrera.Text));
                    c.MostrarAlumnos(db_Alumnos);
                    Txt_NoControl.Text = "";
                    Txt_Nombre.Text = "";
                    Cmb_Carrera.Text = "";
                }

            }
            else { MessageBox.Show("Por favor ingrese 8 Caracteres en el Numero de Control"); }
            
               
            
            
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {

        }

        private void Txt_NoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Txt_NoControl.TextLength == 8)
            {
                if (Txt_NoControl.Text == "")
                {
                    MessageBox.Show("Porfavor Ingrese Numero Control para modificar Nombre o Carrera");
                }
                else
                {
                    MessageBox.Show(c.ModificarAlumnos(Convert.ToInt32(Txt_NoControl.Text), Txt_Nombre.Text, Cmb_Carrera.Text));
                    c.MostrarAlumnos(db_Alumnos);
                    Txt_NoControl.Text = "";
                    Txt_Nombre.Text = "";
                    Cmb_Carrera.Text = "";
                }
            }
            else { MessageBox.Show("Por favor ingrese 8 Caracteres en el Numero de Control"); }
            
           
        }

        private void Btn_Borrar_Click_1(object sender, EventArgs e)
        {
            if (Txt_NoControl.TextLength == 8)
            {
                if (Txt_NoControl.Text == "")
                {
                    MessageBox.Show("Porfavor Ingrese Numero Control para Borrar");
                }
                else
                {
                    MessageBox.Show(c.BorrarAlumno(Convert.ToInt32(Txt_NoControl.Text)));
                    c.MostrarAlumnos(db_Alumnos);
                    Txt_NoControl.Text = "";
                    Txt_Nombre.Text = "";
                    Cmb_Carrera.Text = "";
                }
            }
            else { MessageBox.Show("Por favor ingrese 8 Caracteres en el Numero de Control"); }
        }

        private void Cmb_Carrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NoControl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
