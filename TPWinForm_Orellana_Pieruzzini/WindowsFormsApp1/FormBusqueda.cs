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
using Dominio;

namespace WindowsFormsApp1
{
    public partial class FormBusqueda : Form
    {
        private List<Articulos> Lista = null;

        public FormBusqueda()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;    //centrar pantalla.
            this.ClientSize = new Size(700, 370);

            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\MUNDOVIOLETA.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormBusqueda_Load(object sender, EventArgs e)
        {
            CatologoArticulo catalogo = new CatologoArticulo();
            dgvLista.DataSource = catalogo.Listar();
            dgvLista.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
        }

        private void txtboxBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> Busqueda;
            CatologoArticulo BuscarArticulo = new CatologoArticulo();
            Lista = BuscarArticulo.Listar();
            if(txtboxBusqueda.Text == " ")
            {
                dgvLista.DataSource = Lista;
                Busqueda = Lista;
            }
            else
            {
                Busqueda = Lista.FindAll(Y => Y.Descripcion.ToLower().Contains(txtboxBusqueda.Text.ToLower()) || Y.Nombre.ToLower().Contains(txtboxBusqueda.Text.ToLower()) || Y.Codigo.ToLower().Contains(txtboxBusqueda.Text.ToLower()));
                dgvLista.DataSource = Busqueda;
            }
            dgvLista.DataSource = Busqueda;

        }
    }
}
