using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Pedido
    {
        //Natalia: En este caso todas los atributos estaban como string, pero son int
        public int idPedido { get; }
        public int idUsuario { get; }
        public int idArticulo { get; }
        public int cantidad { get; }

        //Natalia: La funcion no debe tener parametros
        //public Pedido(string idPedido, string idUsuario, string idArticulo, string cantidad)
        public Pedido()
        {
            //Natalia: No esta correcta la sintaxis para el contructor
            //this.idPedido = idPedido;
            //this.idUsuario = idUsuario;
            //this.idArticulo = idArticulo;
            //this.cantidad = cantidad;

            idPedido = 0;
            idUsuario = 0;
            idArticulo = 0;
            cantidad = 0;
        }
    }
}
