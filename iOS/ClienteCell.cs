using Foundation;
using System;
using UIKit;
using ejmeplo1.Entidades;

namespace ejmeplo1.iOS
{
    public partial class ClienteCell : UITableViewCell
    {
        public ClienteCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(Contacto cliente)
        {
            lblNombreCompleto.Text = cliente.Nombre;
            lblCorreo.Text = cliente.Correo;
            lblTelefono.Text = cliente.Telefono;
            switch(cliente.TipoCliente)
            {
                case Enumeradores.TipoCliente.Cliente:
                    {
                        lblEstatus.Text = "Cliente";
                        break;
                    }
                case Enumeradores.TipoCliente.ClientePotencial:
                    {
                        lblEstatus.Text = "Potencial";
                        break;
                    }
                case Enumeradores.TipoCliente.ClienteProspecto:
                    {
                        lblEstatus.Text = "Prospecto";
                        break;
                    }
                case Enumeradores.TipoCliente.ClienteDescartado:
                    {
                        lblEstatus.Text = "Descartado";
                        break;
                    }
                default :
                    {
                        lblEstatus.Text = "Sin definir";
                        break;
                    }
            }
        }
    }
}