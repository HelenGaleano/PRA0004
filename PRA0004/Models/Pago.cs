using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PRA0004.Models
{
    public class Pago
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Photo_recibo { get; set; }
    }
}
