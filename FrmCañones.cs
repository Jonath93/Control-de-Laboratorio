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

    public partial class Frm_Proyectores : Form
    {
        Conexion c=new Conexion();
       
        
        public Frm_Proyectores()
        {
            InitializeComponent();
            c.MostrarCañones(db_cañones);

            this.Btn_Registrar.Enabled = false;
            this.Btn_modificar.Enabled = false;
            this.Btn_Borrar.Enabled = false;
            this.Txt_Clave.Enabled = false;
            this.Txt_Marca.Enabled = false;
            this.Txt_Modelo.Enabled = false;
        }

        private void Btn_Registrar_Click_1(object sender, EventArgs e)
        {
            if (Txt_Clave.TextLength == 3)
            {
                if (Txt_Marca.Text == "" || Txt_Modelo.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese Marca y Modelo para insertar.");
                }
                else
                {
                    MessageBox.Show(c.insertarCañon(Convert.ToInt32(Txt_Clave.Text), Txt_Marca.Text, Txt_Modelo.Text));
                    c.MostrarCañones(db_cañones);
                    Txt_Clave.Text = "";
                    Txt_Marca.Text = "";
                    Txt_Modelo.Text = "";
                }
            }
            else 
            {
                MessageBox.Show("Por favor poner 3 digitos a la clave");
            }
          
            
        }

        private void Txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Btn_Borrar_Click_1(object sender, EventArgs e)
        {
            if (Txt_Clave.TextLength == 3)
            {
                if (Txt_Clave.Text == "")
                {
                    MessageBox.Show("Por favor, solo Ingrese clave para Borrar");
                }
                else
                {
                    MessageBox.Show(c.BorrarCañon(Convert.ToInt32(Txt_Clave.Text)));
                    c.MostrarCañones(db_cañones);
                }
            }
            else
            {
                MessageBox.Show("Por favor poner 3 digitos a la clave");
            }
            

        }

        private void Btn_Consultar_Click_1(object sender, EventArgs e)
        {
            c.MostrarCañones(db_cañones);
            
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            if (Txt_Clave.TextLength == 3)
            {
        
             if ( Txt_Clave.Text=="")
            {
                MessageBox.Show("Por favor, ingrese Clave para modificar la Marca o Modelo");
            }
            else
            {
                MessageBox.Show(c.ModificarCañon( Convert.ToInt32(Txt_Clave.Text), Txt_Marca.Text, Txt_Modelo.Text));
                c.MostrarCañones(db_cañones);
                Txt_Clave.Text = "";
                Txt_Marca.Text = "";
                Txt_Modelo.Text = "";
            }
            }
            else
            {
                MessageBox.Show("Por favor poner  digitos a la clave");
            }
            

        }

        private void Rad_Registrar_Click(object sender, EventArgs e)
        {
            this.Txt_Clave.Enabled = true;
            this.Txt_Marca.Enabled = true;
            this.Txt_Modelo.Enabled = true;
            this.Btn_Registrar.Enabled = true;
            this.Btn_modificar.Enabled = false;
            this.Btn_Borrar.Enabled = false;
        }

        private void Rad_Modificar_Click(object sender, EventArgs e)
        {
            this.Txt_Clave.Enabled = true;
            this.Txt_Marca.Enabled = true;
            this.Txt_Modelo.Enabled = true;
            this.Btn_Registrar.Enabled = false;
            this.Btn_modificar.Enabled = true;
            this.Btn_Borrar.Enabled = false;
        }

        private void Rad_Borrar_Click(object sender, EventArgs e)
        {
            this.Txt_Clave.Enabled = true;
            this.Txt_Marca.Enabled = true;
            this.Txt_Modelo.Enabled = true;
            this.Btn_Registrar.Enabled = false;
            this.Btn_modificar.Enabled = false;
            this.Btn_Borrar.Enabled = true;
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
