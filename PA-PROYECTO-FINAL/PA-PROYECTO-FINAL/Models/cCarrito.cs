using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PA_PROYECTO_FINAL.Models
{
    public class cCarrito
    {
        public Producto _producto { get; set; }

        public int _cantidad { get; set; }

        public cCarrito(Producto producto, int cantidad)
        {
            this._producto = producto;
            this._cantidad = cantidad;
        }


    }
}