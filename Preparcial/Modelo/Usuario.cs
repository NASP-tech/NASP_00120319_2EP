namespace Preparcial.Modelo
{
    class Usuario
    {
        public string IdUsuario { get; set; }

        //Natalia: arreglar NombreUsuario por ----> Nombre
        public string Nombre { get; set; }

        //Natalia: Cambiar contrasena----> contrasenia
        public string Contrasenia { get; set; }

        //Natalia: Cambiar Admin ---> tipo... tambien cambiar String por bool
        public bool Tipo { get; set; }

        //Natalia: arreglar NombreUsuario por ----> Nombre
        //Natalia: La funcion no debe tener parametros
        //public Usuario(string idUsuario, string nombre, string contrasenia, bool tipo)
        public Usuario()
        {
            //IdUsuario = idUsuario;
            //Nombre = nombre;
            //Contrasenia = contrasenia;
            //Tipo = tipo;

            //Natalia: arreglar NombreUsuario por ----> Nombre
            //Natalia: Cambiar contrasena----> contrasenia
            //Natalia: Cambiar Admin ---> tipo

            IdUsuario = "";
            Nombre = "";
            Contrasenia = "";
            Tipo = false;
        }
    }
}
