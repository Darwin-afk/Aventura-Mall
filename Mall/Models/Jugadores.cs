using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Mall.Validaciones;

namespace Mall.Models
{
    public class Jugadores
    {
        private readonly static Jugadores _Jugador = new Jugadores();
        [Key]
        public int JugadorId { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el campo 'Nombres'")]
        [NombresValidacion]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el campo 'Edad'")]
        [EdadValidacion]
        public int Edad { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el campo 'Dinero'")]
        [DineroValidacion]
        public decimal Dinero { get; set; }
        public int Archivo { get; set; }

        private Jugadores()
        {
            JugadorId = 0;
            Nombres = string.Empty;
            Edad = 0;
            Dinero = 0;
            Archivo = 0;
        }

        public static Jugadores Jugador
        {
            get
            {
                return _Jugador;
            }
        }

        public Jugadores(int jugadorId)
        {
            JugadorId = jugadorId;
            Nombres = string.Empty;
            Edad = 0;
            Dinero = 0;
            Archivo = 0;
        }
    }
}
