using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginBD
{
    public partial class frmAggUsuario : Form
    {

        SqlConnection cn = new SqlConnection("SERVER=LAPTOP-6Q2PSGV9;DATABASE=DBBanano;INTEGRATED SECURITY=true");
        

        public frmAggUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT usuario, contrasena FROM usuarios WHERE usuario=@usuario AND contrasena=@contrasena", cn);

            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@contrasena", txtContrasena.Text);

            SqlDataReader result = cmd.ExecuteReader();


            if (result.Read())
            {
                cn.Close();
                Menu pantalla = new Menu();
                pantalla.Show();
            }

                String consulta = "SELECT usuario from usuarios WHERE usuario = @usuario";

                SqlCommand cm = new SqlCommand(consulta, cn); 
                cm.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                int count = (int)cm.ExecuteScalar();

                if(count > 0)
                {
                    throw new Exception("El usuario ya existe en la base de datos");
                }





        }

    
    }
}
