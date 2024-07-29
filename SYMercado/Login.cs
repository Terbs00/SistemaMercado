using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos;
using CapaEntidad;
using CapaMercado;

namespace SYMercado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textDocumento.Text = "";
            textpass.Text = "";
            this.Show();
        }

        private void butingresar_Click(object sender, EventArgs e)
        {

           List<Usuario> TEST = new CM_Usuario().Listar();

      Usuario osuario = new CM_Usuario ().Listar().Where (u => u.documento == textDocumento.Text && u.clave == textpass.Text).FirstOrDefault();
      
      if (osuario != null)
      {
        

          Inicio form = new Inicio();

          form.Show();

          this.Hide();

          form.FormClosing += frm_closing;
      }
      else
      {
          MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
