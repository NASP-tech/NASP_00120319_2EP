namespace ClaseGUI05
{
    public class Inventario
    {
        public string producto { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }

        public Inventario()
        {
            producto = "";
            descripcion = "";
            precio = 0;
            stock = 0;
        }
    }
}