using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Control_de_Laboratorio
{
    class Conexion
    {
          SqlConnection cn;
        SqlCommand cmd;
       //SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Control_del_laboratorio;Integrated Security=True");
                cn.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de dato: "+ex.ToString());
            }

        }
       
       //tabla de cañones

        public string insertarCañon(int No_control,string marca, string modelo) 
        {
            string salida = "Se inserto correctamente";
            try
            {
                cmd = new SqlCommand("set identity_insert Cañones on; insert into Cañones(No_cañon,marca,modelo) values("+No_control+",'" + marca + "','" + modelo + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto:" + ex.ToString();
            }
            return salida;
        }
        public string BorrarCañon(int clave)
        {
            string salida = "Se borro correctamente";
            try
            {
                cmd = new SqlCommand("delete from Cañones where No_cañon="+clave+"", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto:" + ex.ToString();
            }
            return salida;
        }
        public string ModificarCañon(int clave, string marca, string modelo)
        {
            string salida = "Se Modifico correctamente";
            try
            {
                cmd = new SqlCommand("update Cañones set marca ='"+marca+"', modelo='"+modelo+"' where No_cañon="+clave+"", cn);
                cmd = new SqlCommand("update Cañones set marca ='" + marca + "where No_cañon=" + clave + "", cn);
                cmd = new SqlCommand("update Cañones set modelo='" + modelo + "' where No_cañon=" + clave + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto:" + ex.ToString();
            }
            return salida;
        }
        public void MostrarCañones(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select No_cañon as Clave,marca as Marca,modelo as Modelo from Cañones", cn);
                dt=new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }
            
  

        }

       //tabla de Alumnos

        //Registro de alumno
        public string insertarAlumno(int No_control, string nombre, string carrera)
        {
            string salida = "Se inserto correctamente";
            try
            {
                cmd = new SqlCommand("set identity_insert Alumnos on; insert into Alumnos(No_control,Nombre_completo,Carrera) values(" + No_control + ",'" + nombre + "','" + carrera + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto:" + ex.ToString();
            }
            return salida;
        }
        public void MostrarAlumnos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select No_control,Nombre_completo as Nombre,Carrera from Alumnos", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }



        }
        public string ModificarAlumnos(int No_control, string Nombre, string Carrera)
        {
            string salida = "Se Modifico correctamente";
            try
            {
                cmd = new SqlCommand("update Alumnos set Nombre_completo ='" + Nombre + "', Carrera='" + Carrera + "' where No_control=" + No_control + "", cn);
                cmd = new SqlCommand("update Alumnos set Carrera='" + Carrera + "' where No_control=" + No_control + "", cn);
                cmd = new SqlCommand("update Alumnos set Nombre_completo ='" + Nombre + "' where No_control=" + No_control + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto:" + ex.ToString();
            }
            return salida;
        }
        public string BorrarAlumno(int No_control)
        {
            string salida = "Se borro correctamente";
            try
            {
                cmd = new SqlCommand("delete from Alumnos where No_control=" + No_control + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto:" + ex.ToString();
            }
            return salida;
        }
        //insercion de Alumnos ya registrados
        //public int AlumnoRegistrado(int No_control)
        //{
        //    int contador = 0;
        //    string salida = "Se inserto correctamente";
        //    try
        //    {
        //        cmd = new SqlCommand("Select * from Alumnos where No_control="+No_control+"", cn);
        //        cmd.ExecuteNonQuery();
        //        while (dr.Read())
        //        {
        //            contador++;
        //        }
        //        dr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
        //    }
        //    return contador;
        //}


        //tabla de prestamo
        //public string insertarPrestamo(int No_cañon,int No_alumno,string Observaciones,string fecha,string Hora_prestamo,string Hora_entrega)
        //{
        //    string salida = "Se inserto correctamente";
        //    try
        //    {
        //        cmd = new SqlCommand("insert into Prestamo(numero_cañon,numero_de_alumno,observaciones,fecha_prestamo,Hora_prestamo,Hora_entrega) values(" + No_cañon + "," + No_alumno + ",'"+Observaciones+"','"+fecha+"','"+Hora_prestamo+"','"+Hora_entrega+"')", cn);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        salida = "no se conecto:" + ex.ToString();
        //    }
        //    return salida;
        //}
        public string BorrarPrestamo(int No_control)
        {
            string salida = "Se borro correctamente";
            try
            {
                cmd = new SqlCommand("delete from Prestamo where numero_de_alumno=" + No_control + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto:" + ex.ToString();
            }
            return salida;
        }
        //public string BorrarPrestamoMaestro(int clave)
        //{
        //    string salida = "Se borro correctamente";
        //    try
        //    {
        //        cmd = new SqlCommand("delete from PrestamoMaestro where numero_maestro=" +clave + "", cn);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        salida = "no se conecto:" + ex.ToString();
        //    }
        //    return salida;
        //}
        public void MostrarPrestamo(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select c.No_cañon as Clave,c.marca as Cañon, A.Nombre_completo AS Personal,observaciones,fecha_prestamo as Fecha,Hora_prestamo as Prestamo, Hora_entrega as Entrega from Prestamo inner join Cañones as C on numero_cañon=C.No_cañon inner join Alumnos as A on numero_de_alumno=A.No_control", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }



        }
        //public void MostrarPrestamoMaestro(DataGridView dgv)
        //{
        //    try
        //    {
        //        da = new SqlDataAdapter("select c.No_cañon as Clave_Cañon,c.marca as Marca, M.nombre_maestro as Maestro, observaciones,fecha_prestamo as Fecha,Hora_prestamo,Hora_entrega from PrestamoMaestro inner join Cañones as C on numero_cañon=C.No_cañon inner join Maestro as M on numero_maestro=M.No_maestro;", cn);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        dgv.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
        //    }



        //}
        //public string insertarPrestamoMaestro(int No_cañon, int No_maestro, string Observaciones, string fecha, string Hora_prestamo, string Hora_entrega)
        //{
        //    string salida = "Se inserto correctamente";
        //    try
        //    {
        //        cmd = new SqlCommand("insert into PrestamoMaestro(numero_cañon,numero_maestro,observaciones,fecha_prestamo,Hora_prestamo,Hora_entrega) values(" + No_cañon + "," + No_maestro + ",'" + Observaciones + "','" + fecha + "','" + Hora_prestamo + "','" + Hora_entrega + "')", cn);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        salida = "no se conecto:" + ex.ToString();
        //    }
        //    return salida;
        //}
        //Bitacoras Prestamo
        public void bitacoraMaestro(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from bitacoramaestro", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }



        }
        public void bitacoraAlumno(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from bitacora", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }



        }
        //Tabla de maestros
        //public string insertarMaestro(int Clave, string nombre)
        //{
        //    string salida = "Se inserto correctamente";
        //    try
        //    {
        //        cmd = new SqlCommand("set identity_insert Maestro on; insert into Maestro(No_maestro,nombre_maestro) values (" + Clave + ",'" + nombre + "')", cn);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        salida = "no se conecto:" + ex.ToString();
        //    }
        //    return salida;
        //}
        //public void MostrarMaestro(DataGridView dgv)
        //{
        //    try
        //    {
        //        da = new SqlDataAdapter("select No_maestro as Clave,nombre_maestro as Nombre_Maestro from Maestro", cn);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        dgv.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
        //    }



        //}
        //public string ModificarMaestros(int Clave, string Nombre)
        //{
        //    string salida = "Se Modifico correctamente";
        //    try
        //    {
        //        cmd = new SqlCommand("update Maestro set nombre_maestro ='" + Nombre + "' where No_maestro=" + Clave + "", cn);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        salida = "no se conecto:" + ex.ToString();
        //    }
        //    return salida;
        //}
        //public string BorrarMaestro(int Clave)
        //{
        //    string salida = "Se borro correctamente";
        //    try
        //    {
        //        cmd = new SqlCommand("delete from  Maestro where No_maestro=" + Clave + "", cn);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        salida = "no se conecto:" + ex.ToString();
        //    }
        //    return salida;
        //}
    }
}
