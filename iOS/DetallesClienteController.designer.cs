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
    [Register ("DetallesClienteController")]
    partial class DetallesClienteController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnActualizar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnBorrar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRegresar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl segmentEstatus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tfApellidoM { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tfApellidoP { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tfCorreo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tfNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tfTelefono { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnActualizar != null) {
                btnActualizar.Dispose ();
                btnActualizar = null;
            }

            if (btnBorrar != null) {
                btnBorrar.Dispose ();
                btnBorrar = null;
            }

            if (btnRegresar != null) {
                btnRegresar.Dispose ();
                btnRegresar = null;
            }

            if (segmentEstatus != null) {
                segmentEstatus.Dispose ();
                segmentEstatus = null;
            }

            if (tfApellidoM != null) {
                tfApellidoM.Dispose ();
                tfApellidoM = null;
            }

            if (tfApellidoP != null) {
                tfApellidoP.Dispose ();
                tfApellidoP = null;
            }

            if (tfCorreo != null) {
                tfCorreo.Dispose ();
                tfCorreo = null;
            }

            if (tfNombre != null) {
                tfNombre.Dispose ();
                tfNombre = null;
            }

            if (tfTelefono != null) {
                tfTelefono.Dispose ();
                tfTelefono = null;
            }
        }
    }
}