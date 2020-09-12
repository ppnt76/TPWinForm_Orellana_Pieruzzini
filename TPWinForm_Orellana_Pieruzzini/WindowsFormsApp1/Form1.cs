using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;    //centrar pantalla.
            this.ClientSize = new Size(600, 370);

            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\MUNDOVIOLETA.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnListadoArticulos_Click(object sender, EventArgs e)
        {
            Form formulario = new FormListado();
            formulario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
    }
}
