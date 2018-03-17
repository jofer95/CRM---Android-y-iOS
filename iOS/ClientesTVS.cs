using System;
using System.Collections.Generic;
using ejmeplo1.Entidades;
using Foundation;
using UIKit;

namespace ejmeplo1.iOS
{
    internal class ClientesTVS : UITableViewSource
    {
        private List<Contacto> clientes;
        Action<Contacto> contactoSeleccionado;

        public ClientesTVS(List<Contacto> clientes, Action<Contacto> onSelect)
        {
            this.clientes = clientes;
            contactoSeleccionado = onSelect;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (ClienteCell)tableView.DequeueReusableCell("cliente_id", indexPath);
            var cliente = clientes[indexPath.Row];
            cell.UpdateCell(cliente);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return clientes.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var contactoSelecc= clientes[indexPath.Row];
            tableView.DeselectRow(indexPath,true);
            contactoSeleccionado(contactoSelecc);
        }
    }
}