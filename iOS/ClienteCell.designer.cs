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
    [Register ("ClienteCell")]
    partial class ClienteCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCorreo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblEstatus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreCompleto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTelefono { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblCorreo != null) {
                lblCorreo.Dispose ();
                lblCorreo = null;
            }

            if (lblEstatus != null) {
                lblEstatus.Dispose ();
                lblEstatus = null;
            }

            if (lblNombreCompleto != null) {
                lblNombreCompleto.Dispose ();
                lblNombreCompleto = null;
            }

            if (lblTelefono != null) {
                lblTelefono.Dispose ();
                lblTelefono = null;
            }
        }
    }
}