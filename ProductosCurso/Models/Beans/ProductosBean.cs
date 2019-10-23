using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductosCurso.Models.Beans
{
    public class ProductosBean
    {
        public int iIdProducto { get; set; }
        public int iIdCategoria { get; set; }
        public string sNombreProducto { get; set; }
        public decimal dPrecioProducto { get; set; }
        public decimal dDescuentoProducto { get; set; }
        public int iEstadoProducto { get; set; }
        public string sMensaje { get; set; }
    }
}