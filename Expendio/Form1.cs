using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Expendio
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      WindowsMediaPlayer player = new WindowsMediaPlayer();

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
   }
}
