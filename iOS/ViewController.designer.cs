// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ejmeplo1.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCrearCliente { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnListaClientes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTituloApp { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnCrearCliente != null) {
                btnCrearCliente.Dispose ();
                btnCrearCliente = null;
            }

            if (btnListaClientes != null) {
                btnListaClientes.Dispose ();
                btnListaClientes = null;
            }

            if (lblTituloApp != null) {
                lblTituloApp.Dispose ();
                lblTituloApp = null;
            }
        }
    }
}