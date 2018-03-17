// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ejmeplo1.iOS
{
    [Register ("ListaClientesController")]
    partial class ListaClientesController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRegresar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView ClientesTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnRegresar != null) {
                btnRegresar.Dispose ();
                btnRegresar = null;
            }

            if (ClientesTableView != null) {
                ClientesTableView.Dispose ();
                ClientesTableView = null;
            }
        }
    }
}