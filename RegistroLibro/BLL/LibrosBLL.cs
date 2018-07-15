using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroLibro.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;


namespace RegistroLibro.BLL
{
    public class LibrosBLL
    {
            public static Libros Buscar(int id)
            {
                Contexto contexto = new Contexto();
                Libros libros = new Libros();
                try
                {
                    libros = contexto.Libros.Find(id);
                    contexto.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return libros;
            }

            public static bool Guardar(Libros libro)
            {
                bool paso = false;
                Contexto contexto = new Contexto();
                try
                {
                    if(contexto.Libros.Add(libro)!=null)
                    {
                        contexto.SaveChanges(); // guarda los cambio
                        paso = true;
                    }
                    contexto.Dispose(); //connection close
                }
                catch(Exception)
                {
                    throw;
                }
                return paso;
            }

            public static bool Modificar(Libros libro)
            {
                bool paso = false;
                Contexto contexto = new Contexto();
                try
                {
                    contexto.Entry(libro).State = EntityState.Modified;
                    if (contexto.SaveChanges() > 0)
                    {
                        paso = true;
                    }
                    contexto.Dispose();
                }
                catch(Exception)
                {
                    throw;
                }
                return paso;
            }

            public static bool Eliminar(int id)
            {
                bool paso = false;
                Contexto contexto = new Contexto();
                try
                {
                    Libros libro = contexto.Libros.Find(id);
                    contexto.Libros.Remove(libro);
                    if(contexto.SaveChanges()>0)
                    {
                        paso = true;
                    }
                    contexto.Dispose();
                }
                catch(Exception)
                {
                    throw;
                }
                return paso;
            }

            public static List<Libros> GetList(Expression<Func<Libros, bool>> expression)
            {
                List<Libros> ListaLibros = new List<Libros>();
                Contexto contexto = new Contexto();

                try
                {
                    ListaLibros = contexto.Libros.Where(expression).ToList();
                    contexto.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }

                return ListaLibros;
            }

      
    }
}
