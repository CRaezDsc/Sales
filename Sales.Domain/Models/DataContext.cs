namespace Sales.Domain.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        #region Explicacion
        /*
         * Al heredar la clase "base" y enviar el nombre de la cadena de conexion el 
         * contructor de la clase DataContext inicia la coneccion a la base de datos.
        */    
        #endregion
        public DataContext():base("Sales"){}
    }
}
