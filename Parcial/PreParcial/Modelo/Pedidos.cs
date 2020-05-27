namespace ClaseGUI05
{
    public class Pedidos
    {
        public string idusuario { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }

        public Pedidos()
        {
            idusuario = "";
            producto = "";
            cantidad = 0;
        }
    }
}