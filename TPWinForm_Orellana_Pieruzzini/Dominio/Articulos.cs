using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        private int id;

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public Marcas Marca { get; set; }

        public Categoria categoria { get; set; }

        public decimal Precio { get; set; }
    } 

}
