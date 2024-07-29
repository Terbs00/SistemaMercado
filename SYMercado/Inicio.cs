using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Windows.Forms;
using CapaEntidad;

namespace SYMercado
{
    public partial class Inicio : Form
    {

        private static Usuario Usuarioactual; 

        public Inicio(Usuario objusuario)
        {
             
            InitializeComponent();
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
