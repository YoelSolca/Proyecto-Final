namespace CRUDNETBBDD.Datos
{
    public class Conexion
    {
        private string cadenaSQL = string.Empty;

        public Conexion()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            
            cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;


    }
            //Especie de getter de la clase
            public string getCadena() { return cadenaSQL; }
    }
}
