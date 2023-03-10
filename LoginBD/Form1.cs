using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("SERVER=LAPTOP-6Q2PSGV9;DATABASE=DBBanano;INTEGRATED SECURITY=true");

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT usuario, contrasena FROM usuarios WHERE usuario=@usuario AND contrasena=@contrasena", cn);

            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@contrasena", txtContrasena.Text);

            SqlDataReader result = cmd.ExecuteReader();

           
            if (result.Read()) 
            {
                cn.Close();
                Menu pantalla = new Menu();
                pantalla.Show();
            }




        }
    }
}
