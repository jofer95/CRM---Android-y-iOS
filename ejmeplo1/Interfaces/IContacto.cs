using ejmeplo1.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejmeplo1.Interfaces
{
    public interface IContacto
    {
        List<Contacto> ObtenerContactos(TipoCliente tipoContacto);
        Contacto ObtenerContactoPorID(int contactoID);
        void CrearContacto(Contacto contacto);
        void ActualizarContacto(Contacto contacto);
        void BorrarContactoPorID(Contacto contactoID);
        void Inicializar();
    }
}
