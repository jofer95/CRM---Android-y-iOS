using System;
using System.Collections.Generic;
using System.Linq;
using ejmeplo1.Enumeradores;
using ejmeplo1.Interfaces;
using SQLite;

namespace ejmeplo1.Repositorios
{
    public class SQLiteContactoRepository : IContacto
    {
        SQLiteConnection db;
        private static object l = new object();
        public SQLiteContactoRepository(String path)
        {           
            db = new SQLiteConnection(path);
        }

        public void ActualizarContacto(Contacto contacto)
        {
            db.Update(contacto);
        }

        public void BorrarContactoPorID(Contacto contacto)
        {
            db.Delete(contacto);
        }

        public void CrearContacto(Contacto contacto)
        {
            lock (l)
            {
                db.Insert(contacto);
            }
        }

        public void Inicializar()
        {
            //Crear tablas
            db.CreateTable<Contacto>();
        }

        public Contacto ObtenerContactoPorID(int contactoID)
        {
            return db.Find<Contacto>(x => x.ID == contactoID);
        }

        public List<Contacto> ObtenerContactos(TipoCliente tipoContcto)
        {
            return db.Table<Contacto>().Where(x => x.TipoCliente == tipoContcto).ToList();           
        }
    }
}
