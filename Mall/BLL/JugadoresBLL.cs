using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mall.Models;
using Mall.DAL;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Mall.BLL
{
    public class JugadoresBLL
    {
        public static bool Modificar(Jugadores jugador)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(jugador).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        //public static Jugadores Buscar(int id)
        //{
        //    Jugadores jugador = new Jugadores();
        //    Contexto contexto = new Contexto();
        //    try
        //    {
        //        jugador = contexto.Jugadores.Find(id);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        contexto.Dispose();
        //    }
        //    return jugador;
        //}

        public static List<Jugadores> GetList(Expression<Func<Jugadores, bool>> jugador)
        {
            List<Jugadores> Lista = new List<Jugadores>();
            Contexto contexto = new Contexto();
            try
            {
                Lista = contexto.Jugadores.Where(jugador).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}
