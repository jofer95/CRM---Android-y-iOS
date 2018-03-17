using Foundation;
using System;
using UIKit;
using ejmeplo1.Repositorios;

namespace ejmeplo1.iOS
{
    public partial class AddContactoController : UIViewController
    {
        SQLiteContactoRepository repositorio = new SQLiteContactoRepository(ViewController.path);
        public AddContactoController (IntPtr handle) : base (handle)
        {
           

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            btnCrear.TouchUpInside += delegate
            {
                Contacto contacto = new Contacto();
                contacto.ApellidoPaterno = tfApellidoP.Text;
                contacto.ApellidoMaterno = tfApellidoM.Text;
                contacto.Nombre = tfNombre.Text;
                contacto.Correo = tfCorreo.Text;
                contacto.Telefono = tfTelefono.Text;
                contacto.TipoCliente = Enumeradores.TipoCliente.ClientePotencial;
                repositorio.CrearContacto(contacto);
                this.PerformSegue("segueMain",this);
            };
        }
    }
}