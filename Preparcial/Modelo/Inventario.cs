using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Inventario
    {
        //Los atributos deben ser publicos, y deben tener set;
        //Debe ser int y no String
        public int idArticulo { get; set; }

        //Natalia: arreglar producto por --->nombreArt
        public string nombreArt { get; set; }
        public string descripcion { get; set; }
        //Natalia precio y stock deben ser int y no String
        public int precio { get; set; }
        public int stock { get; set; }

        //Natalia: arreglar producto por --->nombreArt
        //Natalia: La funcion no debe tener parametros
        //public Inventario(string idArticulo, string nombreArt, string descripcion, string precio, string stock)
        public Inventario()
        {
            //Natalia: sintaxis incorrecta para el contructor
            //this.idArticulo = idArticulo;
            //this.nombreArt = nombreArt;
            //this.descripcion = descripcion;
            //this.precio = precio;
            //this.stock = stock;
            //Natalia: arreglar producto por --->nombreArt

            idArticulo = 0;
            nombreArt = "";
            descripcion = "";
            precio = 0;
            stock = 0;
        }
    }
}
