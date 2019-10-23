using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductosCurso.Models.Beans
{
    public class CategoriasBean
    {
        public int iIdCategoria { get; set; }
        public string sNombreCategoria { get; set; }
        public string sDescripcionCategoria { get; set; }
        public int iEstadoCategoria { get; set; }

        public string sMensaje { get; set; }

    }
}