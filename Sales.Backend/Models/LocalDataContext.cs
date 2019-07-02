namespace Sales.Backend.Models
{
    using Domain.Models;

    #region Explicacion
    /*  
     *  Esto se hace para facilitar el proeso de migracion de la base de datos.
     *  Se hereda a la clase DataContext, la cual inicia la base de datos.
    */
    #endregion
    public class LocalDataContext:DataContext
    {
        public System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }
    }
}