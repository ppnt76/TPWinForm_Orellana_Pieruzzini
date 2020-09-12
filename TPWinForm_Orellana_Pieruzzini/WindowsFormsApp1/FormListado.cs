using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catologo;

namespace WindowsFormsApp1
{
    public partial class FormListado : Form
    {
        public FormListado()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;    //centrar pantalla.
            this.ClientSize = new Size(600, 370);
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\MUNDOVIOLETA.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void FormListado_Load(object sender, EventArgs e)
        {
                CatologoArticulo catalogo = new CatologoArticulo();
                dgvLista.DataSource = catalogo.Listar();
                dgvLista.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
