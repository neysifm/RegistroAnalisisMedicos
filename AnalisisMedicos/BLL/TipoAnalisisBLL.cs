using AnalisisMedicos.DAL;
using AnalisisMedicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisMedicos.BLL
{
    public class TipoAnalisisBLL
    {
        public static bool Guardar(TiposAnalisis tiposAnalisis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.TiposAnalisi.Add(tiposAnalisis) != null)
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

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.TiposAnalisi.Find(Id);
                contexto.Entry(eliminar).State = EntityState.Deleted;

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

        public static bool Modificar(TiposAnalisis tiposAnalisis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(tiposAnalisis).State = EntityState.Modified;
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

        public static TiposAnalisis Buscar(int Id)
        {
            Contexto contexto = new Contexto();
            TiposAnalisis tiposAnalisis = new TiposAnalisis();
            try
            {
                tiposAnalisis = contexto.TiposAnalisi.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return tiposAnalisis;
        }

        public static List<TiposAnalisis> GetList(Expression<Func<TiposAnalisis, bool>> tiposAnalisis)
        {
            List<TiposAnalisis> Lista = new List<TiposAnalisis>();
            Contexto contexto = new Contexto();
            try
            {
                Lista = contexto.TiposAnalisi.Where(tiposAnalisis).ToList();
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
