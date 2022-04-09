using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using PRA0004.Models;

using System.Threading.Tasks;

namespace PRA0004.Controllers
{
     public static class PagosAntiguedad
    {
        public static SQLiteAsyncConnection dbconexion;
        //Procedimiento estatico

        public static void conexion(string dbpath)
        {
            dbconexion = new SQLiteAsyncConnection(dbpath);
            //Procedemos a crear la tabla  de la base de datos 

            dbconexion.CreateTableAsync<Pago>();
        }


        //procedimientos
        //retorna toda la filas de la tabla Pagos
        public static Task<List<Pago>> ObtenerListaPagos()
        {
            return PagosAntiguedad.dbconexion.Table<Pago>().ToListAsync();
        }

       
        //OPERACIONES CRUD-CREATE-READ-UPDATE-DELETE
        //INSERT-SELECT-UPDATE-DELETE
        //CREATE -UPDATE

        public static Task<int>AddPagos(Pago pagos)
        {
            return PagosAntiguedad.dbconexion.InsertAsync(pagos);
        }
        //Otenemos el ID de un Pago 
        public static Task<Pago>ObtenerPagos(int idP)
        {
            return PagosAntiguedad.dbconexion.Table<Pago>()
                .Where(i => i.ID == idP)
                .FirstOrDefaultAsync();
        }

        //Eliminamos el pago de un monto
        public static Task<int>DelPagoAntiguedad(Pago pagos)
        {
            return PagosAntiguedad.dbconexion.DeleteAsync(pagos);
        }

        public static Task<int> UpdPagos(Pago pagos)
        {
            return PagosAntiguedad.dbconexion.UpdateAsync(pagos);
        }
    }
}
