using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mall.Models
{
    public class CuentasBancarias
    {
        [Key]
        public int CuentaId { get; set; }
        public int JugadorId { get; set; }
        public string Numeracion { get; set; }
        public string NumeroTarjeta { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public decimal Saldo { get; set; }
    }
}
