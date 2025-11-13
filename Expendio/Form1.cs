using System;
using System.Windows.Forms;
using WMPLib;
using System.Data.SqlClient;
using Expendio.Clases;


namespace Expendio
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      WindowsMediaPlayer player = new WindowsMediaPlayer();
      
      //MUSICA
      #region 
      private void btnTecateRoja_Click(object sender, EventArgs e)
      {
         player.URL = @"C:\Users\Emilio Portillo\Music\LasHeladas.mp3";
         player.controls.play();
      }

      private void btnTecateLight_Click(object sender, EventArgs e)
      {
         player.URL = @"C:\Users\Emilio Portillo\Music\SiSoyAma.mp3";
         player.controls.play();
      }


      #endregion

      //EVENTOS PARA LOS TEXTBOX
      #region
      private void txtUsuario_Enter(object sender, EventArgs e)
      {
         if (txtUsuario.Text == "Usuario")
            txtUsuario.Text = "";

         if (txtContraseña.Text != "Contraseña")
            txtContraseña.PasswordChar = '*';
      }

      private void txtUsuario_Leave(object sender, EventArgs e)
      {
         if (txtUsuario.Text == "")
            txtUsuario.Text = "Usuario";
      }

      private void txtContraseña_Enter(object sender, EventArgs e)
      {
         if (txtContraseña.Text == "Contraseña")
            txtContraseña.Text = "";

         txtContraseña.PasswordChar = '*';
      }

      private void txtContraseña_Leave(object sender, EventArgs e)
      {
         if (txtContraseña.Text == "")
            txtContraseña.Text = "Contraseña";

         txtContraseña.PasswordChar = '\0';
      }




      #endregion

      private void btnIngresar_Click(object sender, EventArgs e)
      {
         try
         {
            ConexionLogin login = new ConexionLogin(txtUsuario.Text, txtContraseña.Text);

            string mensaje = login.Login() != 0 ? "Usuario Encontrado" : "Usuario no Encontrado";

            MessageBox.Show(mensaje);

         }
         catch (Exception ex) { MessageBox.Show($"Error: {ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
      }
   }
}
