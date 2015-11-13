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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Btn_Regalum_Click(object sender, EventArgs e)
        {
            Frm_Alumnos Alumnos = new Frm_Alumnos();
            Alumnos.ShowDialog();
        }

        private void Btn_Pres_Click(object sender, EventArgs e)
        {
            FrmPrestamosAlum prestamo = new FrmPrestamosAlum();
            prestamo.ShowDialog();
        }

        private void Btn_Regmaes_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Btn_Regpro_Click_1(object sender, EventArgs e)
        {
            Frm_Proyectores Proyectores = new Frm_Proyectores();
            Proyectores.ShowDialog();
        }

        private void Btn_Exit_Click_1(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("¿Seguro que desea salir?", "Proyectores L5", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Regalum_MouseLeave(object sender, EventArgs e)
        {
            Btn_Regalum.BackgroundImageLayout = ImageLayout.Center;
            Btn_Regalum.BackgroundImage = Properties.Resources._1432598386_group_add;
        }
        private void Btn_Regalum_MouseHover(object sender, EventArgs e)
        {
            Btn_Regalum.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Regalum.BackgroundImage = Properties.Resources._1432598386_group_add;
        }


        private void Btn_Regpro_MouseLeave(object sender, EventArgs e)
        {
            Btn_Regpro.BackgroundImageLayout = ImageLayout.Center;
            Btn_Regpro.BackgroundImage = Properties.Resources._1432598671_plus;
        }
        private void Btn_Regpro_MouseHover(object sender, EventArgs e)
        {
            Btn_Regpro.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Regpro.BackgroundImage = Properties.Resources._1432598671_plus;
        }

        private void Btn_Pres_MouseLeave(object sender, EventArgs e)
        {
            Btn_Pres.BackgroundImageLayout = ImageLayout.Center;
            Btn_Pres.BackgroundImage = Properties.Resources._1432597979_digital_projector;
        }
        private void Btn_Pres_MouseHover(object sender, EventArgs e)
        {
            Btn_Pres.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Pres.BackgroundImage = Properties.Resources._1432597979_digital_projector;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bitacora_Prestamo_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora ();
            bitacora.ShowDialog();

        }
    }
}
