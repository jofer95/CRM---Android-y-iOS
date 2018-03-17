
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ejmeplo1.Enumeradores;
using ejmeplo1.Interfaces;
using ejmeplo1.Repositorios;

namespace ejmeplo1.Droid
{
    [Activity(Label = "Añadir Contacto")]
    public class AddContacto : Activity
    {
        String editarCliente;
        IContacto iContacto = new SQLiteContactoRepository(MainActivity.path);
        //private Button btnAñadirContacto;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            editarCliente = Intent.GetStringExtra("MyData") ?? "";

            //Referencias de las vistas
            SetContentView(Resource.Layout.AddContacto);
            Button btnAñadirContacto = FindViewById<Button>(Resource.Id.btnAddContacto);
            Button btnBorrarContacto = FindViewById<Button>(Resource.Id.btnBorrarContacto);
            EditText edtApellidoP = FindViewById<EditText>(Resource.Id.etApellidoP);
            EditText edtApellidoM = FindViewById<EditText>(Resource.Id.etApellidoM);
            EditText edtNombre = FindViewById<EditText>(Resource.Id.etNombre);
            EditText edtCorreo = FindViewById<EditText>(Resource.Id.etCorreo);
            EditText edtTelefono = FindViewById<EditText>(Resource.Id.etTelefono);
            TextView tvEstatusCliente = FindViewById<TextView>(Resource.Id.tvEstatus);           
            Spinner spnEstatusCliente = FindViewById<Spinner>(Resource.Id.spnTipoCliente);
            var adapter = ArrayAdapter.CreateFromResource(
            this, Resource.Array.TipoClientes, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spnEstatusCliente.Adapter = adapter;

            if (editarCliente.Equals(""))
            {
                tvEstatusCliente.Visibility = ViewStates.Gone;
                spnEstatusCliente.Visibility = ViewStates.Gone;
                btnBorrarContacto.Visibility = ViewStates.Gone;
            }
            else
            {
                btnAñadirContacto.Text = "Editar contacto";
                Contacto contacto = iContacto.ObtenerContactoPorID(Convert.ToInt32(editarCliente));
                edtApellidoP.Text = contacto.ApellidoPaterno;
                edtApellidoM.Text = contacto.ApellidoMaterno;
                edtNombre.Text = contacto.Nombre;
                edtCorreo.Text = contacto.Correo;
                edtTelefono.Text = contacto.Telefono;
                spnEstatusCliente.SetSelection(Convert.ToInt32(contacto.TipoCliente));

            }            

            //Evento onClick del boton de agregar cliente
            btnAñadirContacto.Click += delegate
            {
                Contacto contacto = new Contacto();
                contacto.ApellidoPaterno = edtApellidoP.Text;
                contacto.ApellidoMaterno = edtApellidoM.Text;
                contacto.Nombre = edtNombre.Text;
                contacto.Correo = edtCorreo.Text;
                contacto.Telefono = edtTelefono.Text;
                contacto.TipoCliente = TipoCliente.ClientePotencial;
                if (!editarCliente.Equals(""))
                {
                    //Actualizar contacto
                    contacto.ID = Convert.ToInt32(editarCliente);
                    contacto.TipoCliente = (TipoCliente)spnEstatusCliente.SelectedItemPosition;
                    if (ValidaCampos(contacto))
                    {
                        iContacto.ActualizarContacto(contacto);
                        Finish();
                    }                        
                }
                else
                {
                    //Guardar el contacto en base de datos
                    if (ValidaCampos(contacto))
                    {
                        iContacto.CrearContacto(contacto);
                        Finish();
                    }                        
                }                              
            };
            btnBorrarContacto.Click += delegate
            {
                Contacto contacto = new Contacto();
                contacto.ID = Convert.ToInt32(editarCliente);
                iContacto.BorrarContactoPorID(contacto);
                Finish();
            };
        }

        private bool ValidaCampos(Contacto contacto)
        {
            if (contacto.Correo.Equals("") || contacto.Telefono.Equals(""))
            {
                Toast.MakeText(this, "Faltan campos por capturar", ToastLength.Short).Show();
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
