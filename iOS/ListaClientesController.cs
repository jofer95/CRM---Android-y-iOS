using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using ejmeplo1.Entidades;
using ejmeplo1.Repositorios;

namespace ejmeplo1.iOS
{
    public partial class ListaClientesController : UIViewController
    {
        SQLiteContactoRepository repositorio = new SQLiteContactoRepository(ViewController.path);
        Contacto contactoSeleccionado;
        public ListaClientesController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var clientes = new List<Contacto>();
            Contacto contacto = new Contacto();
            contacto.Nombre = "Pruebas!";
            contacto.Correo = "jofer_bz20@hotmail.com";
            contacto.Telefono = "6671896358";
            contacto.TipoCliente = Enumeradores.TipoCliente.ClientePotencial;

            List<Contacto> contactos = repositorio.ObtenerContactos(Enumeradores.TipoCliente.Cliente);
            foreach(Contacto obj in contactos){
                clientes.Add(obj);
            }
            contactos = repositorio.ObtenerContactos(Enumeradores.TipoCliente.ClientePotencial);
            foreach (Contacto obj in contactos)
            {
                clientes.Add(obj);
            }
            contactos = repositorio.ObtenerContactos(Enumeradores.TipoCliente.ClienteProspecto);
            foreach (Contacto obj in contactos)
            {
                clientes.Add(obj);
            }
            contactos = repositorio.ObtenerContactos(Enumeradores.TipoCliente.ClienteDescartado);
            foreach (Contacto obj in contactos)
            {
                clientes.Add(obj);
            }
            clientes.Add(contacto);

            ClientesTableView.Source = new ClientesTVS(clientes, ContactoSeleccionado);

            ClientesTableView.RowHeight = UITableView.AutomaticDimension;
            ClientesTableView.EstimatedRowHeight = 40f;
            ClientesTableView.ReloadData();
        }

        private void ContactoSeleccionado(Contacto contacto){
            contactoSeleccionado = contacto;
            this.PerformSegue("segueDetalles",this);

        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if(segue.Identifier == "segueDetalles"){
                var detalles = segue.DestinationViewController as DetallesClienteController;
                if(detalles != null){
                    detalles.contacto = contactoSeleccionado;
                }
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}