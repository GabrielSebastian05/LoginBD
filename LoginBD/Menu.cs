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

namespace LoginBD
{
    public partial class Menu : Form
    {
        SqlConnection cn = new SqlConnection("SERVER=LAPTOP-6Q2PSGV9;DATABASE=DBBanano;INTEGRATED SECURITY=true");
        public Menu()
        {
            InitializeComponent();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAggUsuario pantalla = new frmAggUsuario();
            pantalla.Show();
        }

        private void agregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
