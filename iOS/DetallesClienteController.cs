using Foundation;
using System;
using UIKit;
using ejmeplo1.Repositorios;

namespace ejmeplo1.iOS
{
    public partial class DetallesClienteController : UIViewController
    {
        SQLiteContactoRepository repositorio = new SQLiteContactoRepository(ViewController.path);
        //int idContacto;
        public DetallesClienteController()
        {
        }

        public DetallesClienteController(IntPtr handle) : base(handle)
        {

            /*btnBorrar.TouchUpInside += delegate
            {
                Contacto contactoBorrar = repositorio.ObtenerContactoPorID(idContacto);
                repositorio.BorrarContactoPorID(contactoBorrar);
            };*/
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if (contacto != null)
            {
                tfApellidoP.Text = contacto.ApellidoPaterno;
                tfApellidoM.Text = contacto.ApellidoMaterno;
                tfNombre.Text = contacto.Nombre;
                tfCorreo.Text = contacto.Correo;
                tfTelefono.Text = contacto.Telefono;
                //tfEstatus.Text = contacto.TipoCliente.ToString();
                switch (contacto.TipoCliente)
                {
                    case Enumeradores.TipoCliente.Cliente:
                        segmentEstatus.SelectedSegment = 0;
                        break;
                    case Enumeradores.TipoCliente.ClientePotencial:
                        segmentEstatus.SelectedSegment = 1;
                        break;
                    case Enumeradores.TipoCliente.ClienteProspecto:
                        segmentEstatus.SelectedSegment = 2;
                        break;
                    case Enumeradores.TipoCliente.ClienteDescartado:
                        segmentEstatus.SelectedSegment = 3;
                        break;
                }
            }

            btnActualizar.TouchUpInside += delegate
            {
                if (contacto != null)
                {
                    contacto.ApellidoPaterno = tfApellidoP.Text;
                    contacto.ApellidoMaterno = tfApellidoM.Text;
                    contacto.Nombre = tfNombre.Text;
                    contacto.Correo = tfCorreo.Text;
                    contacto.Telefono = tfTelefono.Text;
                    //contacto.TipoCliente = tfEstatus.Text;
                    switch (segmentEstatus.SelectedSegment)
                    {
                        case 0:
                            contacto.TipoCliente = Enumeradores.TipoCliente.Cliente;
                            break;
                        case 1:
                            contacto.TipoCliente = Enumeradores.TipoCliente.ClientePotencial;
                            break;
                        case 2: 
                            contacto.TipoCliente = Enumeradores.TipoCliente.ClienteProspecto;
                            break;
                        case 3:
                            contacto.TipoCliente = Enumeradores.TipoCliente.ClienteDescartado;
                            break;
                    }
                    repositorio.ActualizarContacto(contacto);
                    this.PerformSegue("segueRegresarLista", this);
                }
            };

            btnBorrar.TouchUpInside += delegate
            {
                repositorio.BorrarContactoPorID(contacto);
                this.PerformSegue("segueRegresarLista", this);
            };
        }


        public Contacto contacto
        {
            get;
            set;
        }
    }
}