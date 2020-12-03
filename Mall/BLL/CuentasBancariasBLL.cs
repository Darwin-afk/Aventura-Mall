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
    public class CuentasBancariasBLL
    {
        public static bool Guardar(CuentasBancarias cuentaBancaria)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.CuentasBancarias.Add(cuentaBancaria) != null)
                    paso = contexto.SaveChanges() > 0;
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

        public static bool Modificar(CuentasBancarias cuentaBancaria)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(cuentaBancaria).State = EntityState.Modified;
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

        public static CuentasBancarias Buscar(int id)
        {
            CuentasBancarias cuenta = new CuentasBancarias();
            Contexto contexto = new Contexto();
            try
            {
                cuenta = contexto.CuentasBancarias.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return cuenta;
        }

        public static bool Eliminar(int JugadorId)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                List<CuentasBancarias> Cuentas = CuentasBancariasBLL.GetList(c => c.JugadorId == JugadorId).ToList();

                foreach (var cuenta in Cuentas) 
                {
                    contexto.CuentasBancarias.Remove(cuenta);
                }

                paso = contexto.SaveChanges() > 0;
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

        public static List<CuentasBancarias> GetList(Expression<Func<CuentasBancarias, bool>> cuenta)
        {
            List<CuentasBancarias> Lista = new List<CuentasBancarias>();
            Contexto contexto = new Contexto();
            try
            {
                Lista = contexto.CuentasBancarias.Where(cuenta).ToList();
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
