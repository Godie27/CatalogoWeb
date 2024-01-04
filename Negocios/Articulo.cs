using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Articulo
    {
        public string nombre_articulo { get; set; }
        public string cantidad { get; set; }
        public string subtotal { get; set; }

    }

    public class Compra
    {
        public string userID { get; set; }
        public string total { get; set; }
        public Articulo[] articulos { get; set; }
    }






}
